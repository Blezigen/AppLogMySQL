﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppLogMySQL.Components.Graphics.States
{
    public partial class StateManager : UserControl
    {
        private string currentState = "";
        private string prevState = "";
        private static Dictionary<string, UserControl> states;
        public StateManager()
        {
            states = new Dictionary<string,UserControl>();
            InitializeComponent();
        }

        public bool back() {
            if (prevState != "")
            {
                state_Change(prevState);
                return true;
            }
            return false;
        }

        public void add_State(string name, UserControl _state)
        {
            states[name] = _state;
        }
        public void state_Change(string state){
            this.Controls.Clear();
            this.Controls.Add(states[state]);
            prevState = currentState;
            currentState = state;
        }
    }
}
