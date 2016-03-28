using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                catch (Exception)
                {
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
            public static Exception outOfPreperty;

            /// <summary>
            /// Прошоел ли проверку
            /// </summary>
            public static bool isValidate = false;
            /// <summary>
            /// Полное имя
            /// </summary>
            public static string _full_name = "";
            /// <summary>
            /// Адресс места жительства
            /// </summary>
            public static string _legal_adress = "";
            /// <summary>
            /// Телефоный номер
            /// </summary>
            public static string _telphone = "+7(666)666-66-66";
            /// <summary>
            /// Права доступа
            /// </summary>
            public static string _type = "guest";
            /// <summary>
            /// Номер аккаунта
            /// </summary>
            public static int _id = -1;
            /// <summary>
            /// Пол Мужской или Женский
            /// </summary>
            public static string _gender = "Мужской";

            /// <summary>
            /// Присваивает аккаунту дефолтное значаение
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            public static void SetDefault(){
                _id = -1;//
                isValidate = false;//
                _full_name = "";
                _legal_adress = "";
                _telphone = "+7(666)666-66-66";
                _type = "guest";//
                _gender = "Мужской";
            }

            /// <summary>
            ///     Заполняет аккаунт даными
            /// </summary>
            /// <param name="table"> 
            ///         Достает первое значение из DataTable и потом распределяет все его колонки:
            ///         [ _id = Values on Column "id_unit" ]
            ///         [ _type = Values on Column "type_account" ]
            ///         [ _full_name = Values on Column "full_name" ]
            ///         [ _legal_adress = Values on Column "adress" ]
            ///         [ _telphone = Values on Column "tephone" ]
            ///         [ _gender = Values on Row "gender" and parse(w=>"женский",m=>"мужской") ]
            /// </param>
            public static void FillData(DataTable table)
            {
                if (table.Columns.Contains("validator"))
                    AccountData.isValidate = Int32.Parse(table.Rows[0]["validator"].ToString()) == 1;
                else throw new Exception("Ошибка запроса!");
                if (AccountData.isValidate){
                    if (table.Columns.Contains("id_unit")) 
                        AccountData._id = Int32.Parse(table.Rows[0]["id_unit"].ToString()); 
                    if (table.Columns.Contains("type_account")) 
                        AccountData._type = table.Rows[0]["type_account"].ToString(); 
                    if (table.Columns.Contains("full_name")) 
                        AccountData._full_name = table.Rows[0]["full_name"].ToString(); 
                    if (table.Columns.Contains("adress")) 
                        AccountData._legal_adress = table.Rows[0]["adress"].ToString(); 
                    if (table.Columns.Contains("tephone")) 
                        AccountData._telphone = table.Rows[0]["tephone"].ToString(); 
                }
                else
                {
                    SetDefault();
                    throw new Exception("Неправильный логин пароль!");
                }
                    
                
            }

            public static bool FillData(string login, string password){
                FillData(DataConnection.sqlQueryGetData(String.Format("call getAccountData('{0}','{1}')", login, password)));
                return isValidate;
            }
        };

        public static class ListLogData
        {

        }

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
