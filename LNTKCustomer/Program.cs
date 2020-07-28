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
            
            //////

            List<ShoppedItem> shoppingList = new List<ShoppedItem>();
            ShoppedItem test1 = new ShoppedItem("몬스터X 라지 세트", 26, 1, 8200);
            ShoppedItem test2 = new ShoppedItem("몬스터X 라지 세트", 20, 1, 0);
            ShoppedItem test3 = new ShoppedItem("몬스터X 라지 세트", 21, 1, 0);
            ShoppedItem test4 = new ShoppedItem("닭갈비버거", 27, 1, 3000);

            shoppingList.Add(test1);
            shoppingList.Add(test2);
            shoppingList.Add(test3);
            shoppingList.Add(test4);




            //Application.Run(new ShoppingCart(shoppingList));
            //Application.Run(new EndPage());
            //Application.Run(new CustomerMenu());
            Application.Run(new CustomerMenu());
        }

        private static void ProcessKiller_ShutDown(object sender, ProcessKiller.ShutDownEventArgs e)
        {
            Console.WriteLine($"[{e.Count}] at {DateTime.Now}");
            //
        }
    }
}
