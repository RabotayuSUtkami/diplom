﻿using System;
using System.Collections.Generic;
using System.IO;
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

            string path = "Database.db";
            string resPath = "../../../Database.db";

            try
            {

                if (!File.Exists(path))
                {

                    File.Copy(resPath, path);
                }
            }
            catch {
                MessageBox.Show("База данных не найдена");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formSequence());
            //Application.Run(new formChoice());
            Application.Run(new Form1());
            //Application.Run(new journal());


        }
        public static string user = "";
        public static string id = "";
        public static string courseName = ""; //  название курса для бд
        public static bool flag = false;    // флаг для остановки задач
        public static int cod = 0;  // код для вопроса и ответов для бд(formSequence)
        public static int solved = 0;
        public static int total = 0;
        public static int numLection = 0;
        public static int admin = 0;

        public static int locX = 0;
        public static int locY = 0;
        public static int winWidth = 0;
        public static int winHeight = 0;

    }
    
}
