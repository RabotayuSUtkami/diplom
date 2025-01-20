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
    public partial class usersSeting : Form
    {

        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);


        public usersSeting()
        {
            InitializeComponent();

            sqliteCon.Open();

        }

        private void usersSeting_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            Location = new Point(Program.locX, Program.locY);
            Width = Program.winWidth;
            Height = Program.winHeight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputText.Text != "" && textBox1.Text != "" && inputText.Text.Contains(' ') == false && textBox1.Text.Contains(' ') == false)
            {
                try
                {

                    string id = "";
                    while (true)
                    {
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

                    string query32 = "SELECT login FROM users WHERE login = '" + inputText.Text + "'";
                    SQLiteCommand command42 = new SQLiteCommand(query32, sqliteCon);
                    SQLiteDataReader reader32 = command42.ExecuteReader();
                    string lo = "";
                    foreach (DbDataRecord record in reader32)
                    {
                        lo = record[0].ToString();
                    }
                    if(lo == inputText.Text)
                    {
                        MessageBox.Show("Логин уже существует");
                        return;
                    }

                    string insertTable = "INSERT INTO 'users' (id, login, passw, admin) VALUES ('" + id + "', '" + inputText.Text + "', '" + textBox1.Text + "', '1')";

                    SQLiteCommand command1 = new SQLiteCommand(insertTable, sqliteCon);
                    command1.ExecuteNonQuery();

                    MessageBox.Show("Педагог создан");

                }
                catch
                {
                    MessageBox.Show("Произошла непредвиденная ошибка");
                }
            }
            else
            {
                MessageBox.Show("В логине и пароле не должно быть пробелов.");
            }
        }
    }
}
