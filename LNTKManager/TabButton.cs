using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager
{
    public partial class TabButton : UserControl
    {
        public TabButton()
        {
            InitializeComponent();
        }

        public string Label
        {
            get
            {
                return btnButton.Text;
            }
            set
            {
                btnButton.Text = value;
            }
        }

        public void Deactivate()
        {
            btnButton.ForeColor = Color.Gray;
        }

        public void Acctivate()
        {
            btnButton.ForeColor = Color.Red;
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked(btnButton.Text);
        }

        #region ButtonClicked event things for C# 3.0
        public event EventHandler<ButtonClickedEventArgs> ButtonClicked;

        protected virtual void OnButtonClicked(ButtonClickedEventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }

        private ButtonClickedEventArgs OnButtonClicked(string label)
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs(label);
            OnButtonClicked(args);

            return args;
        }

        private ButtonClickedEventArgs OnButtonClickedForOut()
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs();
            OnButtonClicked(args);

            return args;
        }

        public class ButtonClickedEventArgs : EventArgs
        {
            public string Label { get; set; }

            public ButtonClickedEventArgs()
            {
            }

            public ButtonClickedEventArgs(string label)
            {
                Label = label;
            }
        }
        #endregion
    }
}
