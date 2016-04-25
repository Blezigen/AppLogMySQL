using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppLogMySQL.Components.MySql
{
    class MySQLManager
    {
        private MySqlConnection _connection;
        private static string basic_dbName = "bd_app_log"; //Имя базы данных
        private static string basic_port = "3306";// Порт для подключения
        private static string basic_serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
        private static string basic_userName = "application"; // Имя пользователя
        private static string basic_password = ""; // Пароль для подключения

        public MySqlConnection Connection
        {
            get { 
                return _connection; 
            }
        }

        private string getQueryConnectionString()
        {
            return string.Format("server={0}; user={1}; database={2}; port={3}; password={4};",
                                                    basic_serverName,
                                                    basic_userName,
                                                    basic_dbName,
                                                    basic_port,
                                                    basic_password);
        }

        public bool Open()
        {
            _connection = new MySqlConnection(getQueryConnectionString());
            try
            {
                _connection.Open();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
            return true;
        }

        public DataSet sqlQueryGetData(String query/* Format String */)
        {
            MySqlCommand sqlCom = new MySqlCommand(query, Connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataSet dataValues = new DataSet();
            try
            {
                Connection.Open();
                sqlCom.ExecuteNonQuery();
                dataAdapter.Fill(dataValues);
            }
            catch (MySqlException)
            {
                throw new Exception("FALSE PERMISION");
            }
            finally
            {
                Connection.Close();
            }
            return dataValues;
        }

        public bool sqlQuerySetData(String query/* Format String */)
        {
            MySqlCommand sqlCom = new MySqlCommand(string.Format("call {0}", query), Connection);
            try
            {
                Connection.Open();
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
               Connection.Close();

            }
            return true;
        }

    }
}
