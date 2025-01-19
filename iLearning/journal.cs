using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace iLearning
{
    public partial class journal : Form
    {

        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);

        bool refresh = false;

        public journal()
        {
            InitializeComponent();

            sqliteCon.Open();
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            string id = "";
            while (true) {
                Random rnd = new Random();
                id = rnd.Next(1, 9999).ToString();

                string query3 = "SELECT id FROM users WHERE id = '" + id + "'";
                SQLiteCommand command4 = new SQLiteCommand(query3, sqliteCon);
                SQLiteDataReader reader3 = command4.ExecuteReader();
                string getID = "";
                foreach (DbDataRecord record in reader3)
                {
                    getID = record[0].ToString();
                }

                if (getID != id)
                    break;

                
            }
            idText.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(nameText.Text != "" && idText.Text != "" && nameText.Text.Contains(' ') == false)
            {
                try
                {
                    string log = string.Concat(Enumerable.Repeat("0,", Program.total));
                    log = log.Remove(log.Length - 1);

                    string insertTable = "INSERT INTO 'users' (id, login, course, admin, solved, total, logs) VALUES ('" + idText.Text + "', '" + nameText.Text + "', '" + Program.courseName + "', '0', '0', '0','" + log + "')";

                    SQLiteCommand command1 = new SQLiteCommand(insertTable, sqliteCon);
                    command1.ExecuteNonQuery();

                    dataGridView1.Rows.Add();

                    journal_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Произошла непредвиденная ошибка");
                }



            }
            else
            {
                MessageBox.Show("В имени не должно быть пробелов.");
            }
        }

        private void journal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            Location = new Point(Program.locX, Program.locY);
            Width = Program.winWidth;
            Height = Program.winHeight;


            string stID;
            string stName;
            string stLogs;
            string stSolved;
            string stTotal;


            if (refresh == false)
            {
                for (int i = 0; i < Program.total; i++)
                {
                    dataGridView1.Columns.Add("test" + (i + 1), "Тест " + (i + 1));
                    /* DataGridViewColumn column = dataGridView1.Columns[2 + i];
                     column.Width = 50;*/


                }
                dataGridView1.Columns.Add("Solved", "Выполнено");
                dataGridView1.Columns.Add("Total", "Всего");
            }
            
            string query3 = "SELECT id, login, logs, solved, total FROM users WHERE admin = 0 AND course = '" + Program.courseName + "'";
            SQLiteCommand command4 = new SQLiteCommand(query3, sqliteCon);
            SQLiteDataReader reader3 = command4.ExecuteReader();
            string getID = "";

            int row = 0;
            
            foreach (DbDataRecord record in reader3)
            {
                if (refresh == false)
                    dataGridView1.Rows.Add();

                stID = record[0].ToString();
                stName = record[1].ToString();
                stLogs = record[2].ToString();
                stSolved = record[3].ToString();
                stTotal = record[4].ToString();



                dataGridView1[0, row].Value = stID;
                dataGridView1[1, row].Value = stName;

                int column = 2;

                foreach (string j in stLogs.Split(','))
                {
                    dataGridView1[column, row].Value = j;
                    if(j == "1")
                        dataGridView1[column, row].Style.BackColor = Color.Green;
                    column++;
                }


               


                dataGridView1[column, row].Value = stSolved;
                column++;
                dataGridView1[column, row].Value = stTotal;
                column++;


                
                row++;

                //dataGridView1.Rows.Add("stID", "stName");




            }
            refresh = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
