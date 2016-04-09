﻿using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Resources;

namespace AppLogMySQL.Components.Graphics.Controls
{
    [System.ComponentModel.DesignerCategory("Code")]
    //[Designer(typeof(CustomComboBoxDesigner))]
    public class CustomComboBox : DataGridViewComboBoxCell
    {
        public CustomComboBox()
        {
        }

        public int getSelectedIndex(){
            return this.Items.IndexOf(this.Value);
        }

        public void setSelectedIndex(int value)
        {
            this.Value = this.Items[value];
        } 
    }
    /*internal class CustomComboBoxDesigner : ControlDesigner
    {
        private CustomComboBox control;

        protected override void OnMouseDragBegin(int x, int y)
        {
            base.OnMouseDragBegin(x, y);
            control = (CustomComboBox)(this.Control);
        }
        protected override void OnMouseLeave()
        {
            base.OnMouseLeave();
            control = (CustomComboBox)(this.Control);
        } 
    }*/
}
