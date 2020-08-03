using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager
{
    public partial class GroceryManagement : Form
    {
        public GroceryManagement()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            GroceryInsert form = new GroceryInsert();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GroceryManagement_Load(object sender, EventArgs e)
        {
            bdsGrocery.DataSource = DataRepository.Grocery.GetAllWithProperties();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Grocery grocery = bdsGrocery.Current as Grocery;
            if (grocery == null)
                return;
            GroceryUpdate form = new GroceryUpdate(grocery);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Grocery grocery = bdsGrocery.Current as Grocery;
            if (grocery == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;

            DataRepository.Grocery.Update(grocery);

            bdsGrocery.Remove(grocery);
        }

 
    }
}
