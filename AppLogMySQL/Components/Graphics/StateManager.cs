using System;
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
        public Dictionary<string, UserControl> states;
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
            states.Add(name, _state);
        }
        public void state_Change(string state){
            this.states[state].Parent = null;
            this.Controls.Clear();
            this.Controls.Add(states[state]);
            prevState = currentState;
            currentState = state;
        }

        private void StateManager_Resize(object sender, EventArgs e)
        {
            if (currentState != "")
            {
                states[currentState].Width = this.Width;
                states[currentState].Height = this.Height;
            }
        }
    }
}
