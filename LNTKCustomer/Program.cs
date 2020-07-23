using DevExpressKiller;
using LNTKCustomer.Form;
using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LNTKCustomer
{
    static class Program
    {
        ////
        ///////////////////////////ㄹㄹ
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProcessKiller.Instance.ShutDown += ProcessKiller_ShutDown;
            ProcessKiller.Instance.Start(interval: 500);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            List<ProductPackage> shoppingList = new List<ProductPackage>();
            ProductPackage test = new ProductPackage();
            test.PackageName = "몬스터X 라지 세트";
            List<int> ttt = new List<int>();
            ttt.Add(26);
            ttt.Add(20);
            ttt.Add(21);
            test.productIds = ttt;
            shoppingList.Add(test);
            test.PackageName = "닭갈비버거";
            ttt.Clear();
            ttt.Add(27);
            shoppingList.Add(test);




            Application.Run(new ShoppingCart(shoppingList));
        }

        private static void ProcessKiller_ShutDown(object sender, ProcessKiller.ShutDownEventArgs e)
        {
            Console.WriteLine($"[{e.Count}] at {DateTime.Now}");
        }
    }
}
