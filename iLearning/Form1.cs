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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace iLearning
{
    public partial class Form1 : Form
    {

        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);

        bool flag = false;
        public Form1()
        {
            InitializeComponent();

            sqliteCon.Open();
        }

        private void butCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (butCheckBox.Checked) {
                pass.Visible = false;
                butSignUp.Visible = false;  
                flag = true;
            }
            else
            {
                pass.Visible = true;    
                butSignUp.Visible = true;
                flag = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void butSignUp_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, login, passw FROM users WHERE login = '" + login.Text + "'";
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();

            string id = "";
            string loginT = "";
            string passT = "";

            foreach (DbDataRecord record in reader)
            {
                id = record[0].ToString();
                loginT = record[1].ToString();
                passT = record[2].ToString();
            }


            if (loginT == "")
            {
                try
                {
                    Random rnd = new Random();
                    id = rnd.Next(1, 9999).ToString();
                    string insertTable = "";
                    insertTable = "INSERT INTO 'users' (id, login, passw) VALUES (" + id + ", '" + login.Text + "', '" + pass.Text + "')";

                    SQLiteCommand command1 = new SQLiteCommand(insertTable, sqliteCon);
                    command1.ExecuteNonQuery();

                    MessageBox.Show("Пользователь зарегестрирован");
                }
                catch
                {
                    MessageBox.Show("Возникла непредвиденная ошибка. Попробуйте еще раз.");
                }
            }
            else {
                MessageBox.Show("Пользователь уже зарегестрирован");
            }
        }

        private void butSignIn_Click(object sender, EventArgs e)
        {

           


            if (!flag)
            {
                string query = "SELECT id, login, passw, course FROM users WHERE login = '" + login.Text + "'";
                SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
                SQLiteDataReader reader = command.ExecuteReader();

                string id = "";
                string loginT = "";
                string passT = "";
                string course = "";

                foreach (DbDataRecord record in reader)
                {
                    id = record[0].ToString();
                    loginT = record[1].ToString();
                    passT = record[2].ToString();
                }

                if (login.Text != "" && pass.Text != "" && login.Text == loginT && pass.Text == passT)
                {
                    Program.user = loginT;
                    Program.id = id;

                    menu menu = new menu();
                    menu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else
            {
                string query = "SELECT id, login, passw, course FROM users WHERE id = '" + login.Text + "'";
                SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
                SQLiteDataReader reader = command.ExecuteReader();

                string id = "";
                string loginT = "";
                string passT = "";
                string course = "";

                foreach (DbDataRecord record in reader)
                {
                    id = record[0].ToString();
                    loginT = record[1].ToString();
                    passT = record[2].ToString();
                }

                if (id != "" && id == login.Text)
                {
                    Program.user = loginT;
                    Program.id = id;
                    Program.courseName = course;

                    menu menu = new menu();
                    menu.Show();
                    Hide();
                   
                }
                else
                {
                    MessageBox.Show("Пользователь не существует");
                }
            }
            
        }
    }
}
