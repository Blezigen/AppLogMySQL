using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Drawing;

namespace AppLogMySQL.Components.Data
{
    /// <summary>
    /// Храаним данные аккаунта на стороне клиента для вывода
    /// </summary>
    class AccountManager
    {
        private Byte[] Avatar;
        public Dictionary<string, object> data = new Dictionary<string, object>();

        public void SetDefault()
        {
            data.Clear();
        }

        public Bitmap getAvatar()
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
        public bool FillData()
        {
            SetDefault();
            MySql.SelectQuerys.SQuery_GetBasicAccountData query = new MySql.SelectQuerys.SQuery_GetBasicAccountData();
            query.run(DataManager._connection);
            data = query.getFormatData();
            try
            {
                Avatar = (Byte[])(data["account_image"]);
            }
            catch (System.InvalidCastException)
            {
                Avatar = null;
            }
            return true;
        }

        public Dictionary<string, object> login(string login, string password)
        {
            MySql.SelectQuerys.SQuery_LoginAccount query = new MySql.SelectQuerys.SQuery_LoginAccount();
            query.login = login;
            query.password = password;
            query.run(DataManager._connection);
            return query.getFormatData();
        }
    }
}
