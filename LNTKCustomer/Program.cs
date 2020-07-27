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
            ProductPackage test1 = new ProductPackage();
            ProductPackage test2 = new ProductPackage();
            test1.PackageName = "몬스터X 라지 세트";
            List<int> ttt = new List<int>();
            ttt.Add(26);
            ttt.Add(20);
            ttt.Add(21);
            test1.productIds = ttt;
            test1.Quantity = 2;
            test1.GetTotalPrice();
            shoppingList.Add(test1);
            test2.PackageName = "닭갈비버거";
            List<int> ttt2 = new List<int>();
            ttt2.Add(27);
            test2.productIds = ttt2;
            test2.Quantity = 1;
            test2.GetTotalPrice();
            shoppingList.Add(test2);





            //  Application.Run(new ShoppingCart(shoppingList));
            Application.Run(new EndPage());
        }

        private static void ProcessKiller_ShutDown(object sender, ProcessKiller.ShutDownEventArgs e)
        {
            Console.WriteLine($"[{e.Count}] at {DateTime.Now}");
        }
    }
}
