using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLearning
{
    public partial class formChoice : Form
    {
        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);


        bool flag = false;
        bool trueFlag;
        string trueCount;

        Color sysColor;

        public formChoice()
        {
            InitializeComponent();

            sqliteCon.Open();      
        }

        private void formChoice_Load(object sender, EventArgs e)
        {
            sysColor = Color.LightGray;

            Dictionary<int, string> map = new Dictionary<int, string>();
           

            string query = "SELECT question, trueanswer, answer1, answer2, answer3 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();
          
            string Trueanswer = "";
            string Answer1 = "";
            string Answer2 = "";
            string Answer3 = "";





            foreach (DbDataRecord record in reader)
            {
                question.Text = record[0].ToString();
                Trueanswer = record[1].ToString();
                Answer1 = record[2].ToString();
                Answer2 = record[3].ToString();
                Answer3 = record[4].ToString();

            }


            map = new Dictionary<int, string>(){
                { 1, Trueanswer},
                { 2, Answer1},
                { 3, Answer2},
                { 4, Answer3},
            };

            int count = 0;
            int[] mas = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int a = rnd.Next(1, 5);
                for (int j = 0; j < 4; j++)
                {
                    if (a != mas[j])
                        count++;
                    else { i--; break; }
                    if (count == 4)
                    {
                        mas[i] = a;
                        count = 0;
                    }
                }
            }
            variant1.Text = map[mas[0]];
            variant2.Text = map[mas[1]];
            variant3.Text = map[mas[2]];
            variant4.Text = map[mas[3]];

        }


        private void growth(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (flag == false)
            {
                btn.Size = new System.Drawing.Size(btn.Width + 10, btn.Height + 10);
                btn.Location = new Point(btn.Location.X - 5, btn.Location.Y - 5);
            }
            flag = true;
        }

        private void lowering(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (flag == true)
            {
                btn.Size = new System.Drawing.Size(btn.Width - 10, btn.Height - 10);
                btn.Location = new Point(btn.Location.X + 5, btn.Location.Y + 5);
            }
            flag = false;
        }


     

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            growth(sender, e);        
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lowering(sender, e);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            growth(sender, e);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            lowering(sender, e);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            growth(sender, e);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            lowering(sender, e);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            growth(sender, e);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            lowering(sender, e);
        }

        private void variant2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            process(btn);
        }

        private void variant1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            process(btn);
        }

        private void variant3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            process(btn);
        }

        private void variant4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            process(btn);
            
        }

        private void process(Button btn)
        {



            variant1.BackColor = sysColor;
            variant2.BackColor = sysColor;
            variant3.BackColor = sysColor;
            variant4.BackColor = sysColor;

            btn.BackColor = Color.Gold;

            string text = btn.Text;


            string query = "SELECT trueanswer FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();

            string Trueanswer = "";           

            foreach (DbDataRecord record in reader)
            {
                Trueanswer = record[0].ToString();               
            }


            string query2 = "SELECT val FROM processing WHERE field = 'solved'";
            SQLiteCommand command2 = new SQLiteCommand(query2, sqliteCon);
            SQLiteDataReader reader2 = command2.ExecuteReader();

            trueCount = "";

            foreach (DbDataRecord record in reader2)
            {
                trueCount = record[0].ToString();
            }
            




            try
            {
                Convert.ToInt32(trueCount);
            }
            catch
            {
                trueCount = "0";
            }

            if (text == Trueanswer)
            {
                trueFlag = true;
            }
            else
            {
                trueFlag = false;
            }

          /*  int razn = (this.Width - button1.Width) / 10;
                   
            for (int i = 0; i <= 10; i++) {

                button1.Width += razn;
              
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
            button1.Width = this.Width;

            for (int i = 0; i <= 10; i++)
            {

                button1.Width -= razn;
                button1.Location = new Point(button1.Location.X + razn, button1.Location.Y);
                Thread.Sleep(10);
                System.Windows.Forms.Application.DoEvents();
            }*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trueFlag)
            {
                int newTrueCount = Convert.ToInt32(trueCount);
                newTrueCount++;

                string updateQuery = "UPDATE processing SET val = " + newTrueCount + " WHERE field = 'solved'";
                SQLiteCommand command2 = new SQLiteCommand(updateQuery, sqliteCon);
                command2.ExecuteNonQuery();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            this.Close();
        }
    }
}
