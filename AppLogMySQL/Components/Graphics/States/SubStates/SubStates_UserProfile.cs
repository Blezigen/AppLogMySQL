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
        int index = 0;
        int marginItems = 10;
        public SubStates_UserProfile()
        {
            InitializeComponent();
            
        }

        private void AddNewRow(string _title,string _value) {
            Label title = new Label();
            Label value = new Label();
            Components.Graphics.Controls.CustomPanel HR = new Components.Graphics.Controls.CustomPanel();
            Components.Graphics.Controls.CustomPanel Item = new Components.Graphics.Controls.CustomPanel();

            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.Location = new System.Drawing.Point(12, 0);
            title.Name = String.Format("Title{0}", index);
            title.Size = new System.Drawing.Size(58, 19);
            title.Text = string.Format("{0}:",_title);
            // 
            // value
            // 
            value.AutoSize = true;
            value.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            value.Location = new System.Drawing.Point(254, 0);
            value.Name = String.Format("Value{0}", index);
            value.Size = new System.Drawing.Size(0, 19);
            value.Text = _value;
            //
            // HR
            //
            HR.BackColor = Color.Black;
            HR.BorderColor = Color.Transparent;
            HR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
            HR.Location = new System.Drawing.Point(0, 20);
            HR.Name = String.Format("HR{0}",index);
            HR.Size = new System.Drawing.Size(620, 1);
            //
            // ITEM
            //
            Item.BorderColor = Color.Transparent;
            Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
            Item.Name = String.Format("Item{0}", index);
            Item.Size = new System.Drawing.Size(620, 21);
            Item.Location = new System.Drawing.Point(0, ((HR.Location.Y + 1 + marginItems) * index));
            Item.Controls.Add(title);
            Item.Controls.Add(value);
            Item.Controls.Add(HR);

            ListDataProfile.Controls.Add(Item);
            index++;
        }

        public void LoadProfile()
        {
            if (DataManager._account.getAvatar()!=null)
            {
                this.ProfileImage.Image = DataManager._account.getAvatar();
            }
            else
            {
                this.ProfileImage.Image = ResourceApplication.DefaulAvatar;
            }
            foreach(KeyValuePair<string,object> row in DataManager._account.data){
                if (row.Key.ToString() != "account_image")
                AddNewRow(row.Key.ToString(),row.Value.ToString());
            }
        }

        private void SubStates_UserProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }
    }
}
