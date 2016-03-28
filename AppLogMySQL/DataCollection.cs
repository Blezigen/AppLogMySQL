using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace AppLogMySQL
{
    static public partial class DataCollection
    {
        public static MainForm mainFormer;
        //Типы данных
        public static class DataConnection
        {
            public static MySqlConnection connection;
            private static string basic_port = "3306"; // Порт для подключения
            private static string basic_serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            private static string basic_userName = "userGetConnection"; // Имя пользователя
            private static string basic_dbName = "bd_app_log"; //Имя базы данных
            private static string basic_password = ""; // Пароль для подключения
            public static string getQueryString(){
            return string.Format("server={0}; user={1}; database={2}; port={3}; password={4};",
                                                        basic_serverName,
                                                        basic_userName,
                                                        basic_dbName,
                                                        basic_port,
                                                        basic_password);
            }

            public static bool initialiseConnection()
            {
                connection = new MySqlConnection(getQueryString());
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
                return true;
            }
            public static DataTable sqlQueryGetData(String query/* Format String */)
            {
                MySqlCommand sqlCom = new MySqlCommand(query, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
                DataTable dataValues = new DataTable();
                try
                {
                    connection.Open();
                    sqlCom.ExecuteNonQuery();
                    dataAdapter.Fill(dataValues);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
                return dataValues;
            }
            public static bool sqlQuerySetData(String query/* Format String */)
            {
                MySqlCommand sqlCom = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
                return true;
            }
        }

        /// <summary>
        /// Храаним данные аккаунта на стороне клиента для вывода
        /// </summary>
        public static class AccountData
        {
            private static Byte[] Avatar;
            public static Dictionary<string, object> data = new Dictionary<string, object>();
            public static void SetDefault(){
                data.Clear();
            }

            public static Bitmap getAvatar()
            {
                if (Avatar != null)
                {
                    MemoryStream mStream = new MemoryStream();
                    byte[] pData = Avatar;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    Bitmap bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    return bm;
                }
                return null;
            }

            /// <summary>
            ///     Заполняет аккаунт даными
            /// </summary>
            /// <param name="table"> 
            ///         Достает первое значение из DataTable и потом распределяет все его колонки в data:
            /// </param>
            public static void FillData(DataTable table)
            {
                SetDefault();
                if (table != null)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        if (column.ColumnName != "account_image")
                        {
                            data[column.ColumnName] = table.Rows[0][column.ColumnName];
                        }
                        else
                        {
                            try{
                                Avatar = (Byte[])(table.Rows[0][column.ColumnName]);
                            }catch (System.InvalidCastException){
                                Avatar = null;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные аккаунта!!!");
                }
                
            }

            public static Dictionary<string, object> loginAccount(string login, string password)
            {
                var SuccesLogin = new Dictionary<string, object>();
                try
                {
                    DataTable loginAnswer = DataConnection.sqlQueryGetData(String.Format("call loginAccount('{0}','{1}')", login, password));
                    SuccesLogin["is_valid"] = int.Parse(loginAnswer.Rows[0]["validator"].ToString()) == 1;
                    SuccesLogin["message"] = loginAnswer.Rows[0]["message"].ToString();
                    if ((bool)SuccesLogin["is_valid"])
                    {
                        DataTable dt = DataConnection.sqlQueryGetData("call getBasicAccountData()");
                        FillData(dt);
                    }
                    return SuccesLogin;
                }
                finally
                {

                }
            }
        };

        public class PanelControllData
        {
            public static bool is_logs_active = false;
            public static int selected_group_logs = -1;
            public static int selected_discipline_logs = -1;
            public static String isGroupSelected()
            {
                if (selected_group_logs >= 0)
                    return "G";
                return "";
            }
            public static string isDisciplineSelected()
            {
                if (selected_discipline_logs >= 0)
                    return "D";
                return "";
            }
        };

        public static class DataLogController
        {
            public static string valueData;
            public static int year = 2015;
            public static int month = 9;
            public static int date = 06;
            public static int idStudent = 1;
            public static int workType = 0;

            public static string getCustomDate()
            {
                return string.Format("{0}-{1}-{2}", year, month, date);
            }
            public static string getQueryString()
            {
                return string.Format("call InserLogValue({0},{1},{2},{3})", getCustomDate(), valueData, idStudent, workType);
            }
        };

        // Супер глобальные переменные
        public static DataTable log_days = new DataTable();
        public static DataTable GroupCollection = new DataTable();
        public static DataTable DisciplineCollection = new DataTable();
        public static PanelControllData data_panel_controll;

        //Супер глобальные функции
        public static Action<System.Windows.Forms.UserControl> _NextForm;
        public static Action _PrevForm;

        


        public static DataTable queryGetLogData(){
            return DataConnection.sqlQueryGetData("call showFullLogs();");
        }

        public static DataTable queryGetListLogsData(int worker_id)
        {
            String iType;
            String Params = "";
            iType = String.Format("{0}{1}", PanelControllData.isGroupSelected(), PanelControllData.isDisciplineSelected());
            switch (iType)
            {
                case "GD": Params = String.Format("{0},{1},{2}", worker_id, GroupCollection.Rows[PanelControllData.selected_group_logs][1], DisciplineCollection.Rows[PanelControllData.selected_discipline_logs][1]); break;
                case "G": Params = String.Format("{0},{1}", worker_id, GroupCollection.Rows[PanelControllData.selected_group_logs][1]); break;
                case "D": Params = String.Format("{0},{1}", worker_id, DisciplineCollection.Rows[PanelControllData.selected_discipline_logs][1]); break;
                default: Params = String.Format("{0}", worker_id); break;
            }

            return DataConnection.sqlQueryGetData(String.Format("call getListLogsByW{0}({1});", iType, Params));
        }

        public static DataTable queryGetGroupsData()
        {
            return DataConnection.sqlQueryGetData("call getGroups();");
        }

        public static DataTable queryGetDisciplineData()
        {
            return DataConnection.sqlQueryGetData("call getDiscipline();");
        }

        public static DataTable queryGetStudentsIntoGroupData()
        {
            return DataConnection.sqlQueryGetData("call getStudentsIntoGroup();");
        }

        public static bool querySelectGADData(int G, int D)
        {
            return DataConnection.sqlQuerySetData(String.Format("call selectGroupAndDiscipline({0},{1})", G, D));
        }

        public static void insertLogValue(string dayDate, string dayValue, int idStudent, int workType)
        {
            string run_procedure_query = String.Format("call InserLogValue({0},{1},{2},{3})", dayDate, dayValue, idStudent, workType);
            MySqlCommand sqlCom = new MySqlCommand(run_procedure_query, DataConnection.connection);
            try
            {
                DataConnection.connection.Open();
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DataConnection.connection.Close();
            }
        }

    }
}
