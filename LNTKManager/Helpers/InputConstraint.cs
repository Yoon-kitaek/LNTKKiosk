using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTKManager.Helpers
{
    public static class InputConstraint
    {
        internal static void OnlyIntConstraint(TextEdit txe)
        {
            if (txe.Text == "")
                return;
            try
            {
                uint.Parse(txe.Text);
            }
            catch
            {
                MessageBox.Show("숫자만 입력하세요.");
                txe.Refresh();
            }
        }

        internal static void DateConstraint(TextEdit txe)
        {

            try
            {
                DateTime.ParseExact(txe.Text, "yyyyMMdd", null);
            }
            catch
            {
                MessageBox.Show("날짜 입력양식에 맞추세요 \n ex) 19900412");
            }
        }
    }
}
