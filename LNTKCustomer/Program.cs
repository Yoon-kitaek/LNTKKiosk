﻿using DevExpressKiller;
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
            //ProcessKiller.Instance.ShutDown += ProcessKiller_ShutDown;
            //ProcessKiller.Instance.Start(interval: 500);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            
            //////

 


            //Application.Run(new ShoppingCart(shoppingList));
            //Application.Run(new EndPage());
            Application.Run(new WaitScreen());
          // Application.Run(new IngredientThumbnail());
        }

        private static void ProcessKiller_ShutDown(object sender, ProcessKiller.ShutDownEventArgs e)
        {
            Console.WriteLine($"[{e.Count}] at {DateTime.Now}");
            //
        }
    }
}
