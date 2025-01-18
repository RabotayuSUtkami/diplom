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
    public partial class journal : Form
    {

        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);



        public journal()
        {
            InitializeComponent();

            sqliteCon.Open();
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            while (true) {
                Random rnd = new Random();
                string id = rnd.Next(1, 9999).ToString();

                string query3 = "SELECT id FROM users WHERE id = '" + id + "'";
                SQLiteCommand command4 = new SQLiteCommand(query3, sqliteCon);
                SQLiteDataReader reader3 = command4.ExecuteReader();
                string getID = "";
                foreach (DbDataRecord record in reader3)
                {
                    getID = record[0].ToString();
                }

                if (getID == "")
                    break;

                idText.Text = id;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
