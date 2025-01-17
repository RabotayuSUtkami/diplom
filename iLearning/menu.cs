using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


using System.Data.SQLite;
using System.Data.Common;


namespace iLearning
{
    public partial class menu : Form
    {
        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);



        public menu()
        {
            InitializeComponent();
            
            sqliteCon.Open();

        }

        private void menu_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.flag = true;

            string query = "SELECT COUNT(*) FROM " + Program.courseName;
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();
            string i = "";
            foreach (DbDataRecord record in reader)
            {
                i = record[0].ToString();
            }


            string updateQuery = "UPDATE processing SET val = " + i + " WHERE field = 'total'";
            SQLiteCommand command2 = new SQLiteCommand(updateQuery, sqliteCon);
            command2.ExecuteNonQuery();

           


            string query2 = "SELECT val FROM processing WHERE field = 'solved'";
            SQLiteCommand command3 = new SQLiteCommand(query2, sqliteCon);
            SQLiteDataReader reader2 = command3.ExecuteReader();
            string trueCount = "";
            foreach (DbDataRecord record in reader2)
            {
                trueCount = record[0].ToString();
            }
            Console.WriteLine("trueCoiynt " + trueCount);





            for (int j = 1; j <= Convert.ToInt32(i); j++)
            {

                if (Program.flag == false)
                    break;


                Program.cod = j;
              


                string query3 = "SELECT type FROM " + Program.courseName + " WHERE Код = " + j;
                SQLiteCommand command4 = new SQLiteCommand(query3, sqliteCon);
                SQLiteDataReader reader3 = command4.ExecuteReader();
                string type = "";
                foreach (DbDataRecord record in reader3)
                {
                    type = record[0].ToString();
                }


                switch (type)
                {
                    case "choice":
                        formChoice formChoice = new formChoice();
                        formChoice.ShowDialog();
                        break;
                    case "sequence":
                        formSequence formSequence = new formSequence();
                        formSequence.ShowDialog();
                        break;
                    case "text":
                        formText formText = new formText();
                        formText.ShowDialog();
                        break;

                }


            }

        }
    }
}
