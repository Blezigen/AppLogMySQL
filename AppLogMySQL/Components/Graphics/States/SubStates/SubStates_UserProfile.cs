using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppLogMySQL.Components.Data;

namespace AppLogMySQL.Components.Graphics.States.SubStates
{
    public partial class SubStates_UserProfile : UserControl
    {
        public SubStates_UserProfile()
        {
            InitializeComponent();
            
        }

        public void LoadProfile()
        {
            GeneralDataGrid.Rows.Clear();
            if (DataManager._account.getAvatar()!=null)
            {
                this.ProfileImage.Image = DataManager._account.getAvatar();
            }
            else
            {
                this.ProfileImage.Image = ResourceApplication.DefaulAvatar;
            }

            //GeneralDataGrid.DataSource = DataManager._account._dataset.Tables[0];


            foreach(KeyValuePair<string,object> row in DataManager._account.data){
                if (row.Key.ToString() != "account_image")
                {
                    GeneralDataGrid.Rows.Add(row.Key.ToString(), row.Value.ToString());
                }
                //AddNewRow(row.Key.ToString(),row.Value.ToString());
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            LoadProfile();
            switch (AppLogMySQL.Components.Data.DataManager._account._dataset.Tables[0].Rows[0]["Права доступа:"].ToString())
            {
                case "Администратор": buttonAVG.Visible = false; break;
                case "Преподаватель": buttonAVG.Visible = false; break;
                case "Студент": buttonAVG.Visible = true; break;
                default: buttonAVG.Visible = false; break;
            }

            base.OnPaint(e);
        }
        private void SubStates_UserProfile_Load(object sender, EventArgs e)
        {
            //LoadProfile();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //LoadProfile();
        }

        private void buttonAVG_Click(object sender, EventArgs e)
        {
            Dialog.Dialog_SAE_Log_AVG d = new Dialog.Dialog_SAE_Log_AVG();
            d.Show(int.Parse(DataManager._account._dataset.Tables[0].Rows[0]["id:"].ToString()));
        }
    }
}
