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
    public partial class ButtonContainer : UserControl
    {
        public ButtonContainer()
        {
            InitializeComponent();

            _tabButtons.Add(uscTabButton0);
            _tabButtons.Add(uscTabButton1);
            _tabButtons.Add(uscTabButton2);
        }

        private List<TabButton> _tabButtons = new List<TabButton>();

        private void uscTabButton_ButtonClicked(object sender, TabButton.ButtonClickedEventArgs e)
        {
            TabButton tabButton = sender as TabButton;
            
            tabButton.Acctivate();

            _tabButtons
                .FindAll(x => x != tabButton)
                .ForEach(x => x.Deactivate());

            OnMenuSelected(e.Label);
        }

        #region MenuSelected event things for C# 3.0
        public event EventHandler<MenuSelectedEventArgs> MenuSelected;

        protected virtual void OnMenuSelected(MenuSelectedEventArgs e)
        {
            if (MenuSelected != null)
                MenuSelected(this, e);
        }

        private MenuSelectedEventArgs OnMenuSelected(string label)
        {
            MenuSelectedEventArgs args = new MenuSelectedEventArgs(label);
            OnMenuSelected(args);

            return args;
        }

        private MenuSelectedEventArgs OnMenuSelectedForOut()
        {
            MenuSelectedEventArgs args = new MenuSelectedEventArgs();
            OnMenuSelected(args);

            return args;
        }

        public class MenuSelectedEventArgs : EventArgs
        {
            public string Label { get; set; }

            public MenuSelectedEventArgs()
            {
            }

            public MenuSelectedEventArgs(string label)
            {
                Label = label;
            }
        }
        #endregion
    }

}
