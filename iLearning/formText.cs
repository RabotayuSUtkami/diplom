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
            string query = "SELECT question FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();


            foreach (DbDataRecord record in reader)
            {
                questionText.Text = record[0].ToString();  
            }
        }


        private int Checking()
        {

            string query = "SELECT trueanswer FROM " + Program.courseName + " WHERE Код = " + Program.cod;
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
            string query2 = "SELECT val FROM processing WHERE field = 'solved'";
            SQLiteCommand command2 = new SQLiteCommand(query2, sqliteCon);
            SQLiteDataReader reader2 = command2.ExecuteReader();

            string trueCount = "";

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


            if (inputText.Text != "" || inputText.Text != " ")
            {
                int a = Checking();

                if (a == 1)
                {
                    int newTrueCount = Convert.ToInt32(trueCount);
                    newTrueCount++;

                    string updateQuery = "UPDATE processing SET val = " + newTrueCount + " WHERE field = 'solved'";
                    SQLiteCommand command0 = new SQLiteCommand(updateQuery, sqliteCon);
                    command0.ExecuteNonQuery();
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
