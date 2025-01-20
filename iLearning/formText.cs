using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLearning
{
    public partial class formText : Form
    {

        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);


        public formText()
        {
            InitializeComponent();

            sqliteCon.Open();
        }

        private void formText_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            Location = new Point(Program.locX, Program.locY);
            Width = Program.winWidth;
            Height = Program.winHeight;




            string query = "SELECT question FROM '" + Program.courseName + "' WHERE Код = " + Program.cod;
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();


            foreach (DbDataRecord record in reader)
            {
                questionText.Text = record[0].ToString();  
            }
        }


        private int Checking()
        {

            string query = "SELECT trueanswer FROM '" + Program.courseName + "' WHERE Код = " + Program.cod;
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();

            string trueText = "";

            foreach (DbDataRecord record in reader)
            {
                trueText = record[0].ToString();
            }

            if(inputText.Text == trueText)
                return 1;
            else return 0;
        }




        private void button1_Click(object sender, EventArgs e)
        {
           
            if (inputText.Text != "" || inputText.Text != " ")
            {
                int a = Checking();

                if (a == 1)
                {
                    string query3 = "SELECT logs FROM users WHERE id = " + Program.id + " AND course = '" + Program.courseName + "'";
                    SQLiteCommand command4 = new SQLiteCommand(query3, sqliteCon);
                    SQLiteDataReader reader3 = command4.ExecuteReader();

                    List<int> results = new List<int>();


                    foreach (DbDataRecord record in reader3)
                    {

                        string stLogs = record[0].ToString();

                        foreach (string j in stLogs.Split(','))
                        {
                            results.Add(int.Parse(j));
                        }
                    }
                    results[Program.cod - 1] = 1;

                    string updateQuery = "UPDATE users SET logs = '" + String.Join(",", results) + "' WHERE id = " + Program.id;
                    SQLiteCommand command3 = new SQLiteCommand(updateQuery, sqliteCon);
                    command3.ExecuteNonQuery();
                }

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
