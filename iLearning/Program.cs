﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLearning
{

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 


        
        [STAThread]
        static void Main()
        {

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formSequence());
            //Application.Run(new formChoice());
            Application.Run(new menu());

            
        }
        public static string courseName = "c#";
        public static bool flag = false;
        public static int cod = 0;
    }
    
}
