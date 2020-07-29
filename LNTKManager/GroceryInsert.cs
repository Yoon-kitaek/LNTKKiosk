using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager
{
    public partial class GroceryInsert : Form
    {
        public GroceryInsert()
        {
            InitializeComponent();
        }

        private Grocery _grocery;

        private void WriteToEntity()
        {
            _grocery.CodeCategoryId = (int?)cbbCategoryId.SelectedValue;

            try
            {
                _grocery.Unit = int.Parse(txeUnit.Text);
            }
            catch (Exception)
            {
                Helpers.InputConstraint.OnlyIntConstraint(txeUnit);
            }
            _grocery.Item = txeName.Text;
        }

        private void GroceryInsert_Load(object sender, EventArgs e)
        {
            bdsCategory.DataSource = DataRepository.CodeCategory.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txeUnit.Text == "")
            {
                MessageBox.Show("1개의 g을 입력해주세요");
                return;
            }

            if(txeName.Text == "")
            {
                MessageBox.Show("식재료명을 입력해주세요");
                return;
            }
            _grocery = new Grocery();
            WriteToEntity();

            try
            {
                DataRepository.Grocery.Insert(_grocery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("등록되었습니다.");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txeUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
