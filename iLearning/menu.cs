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

namespace iLearning
{
    public partial class menu : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;


        public menu()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();


        }

        private void menu_Load(object sender, EventArgs e)
        {
       

            /*
                        string L;
                        string query = "SELECT pas FROM users WHERE log = '" + textBox1.Text + "'";
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        L = command.ExecuteScalar().ToString();


                        string query = "INSERT INTO users (log, pas) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        command.ExecuteNonQuery();



                        string query = "CREATE TABLE " + textBox1.Text + " (Код Int IDENTITY(1,1) NOT NULL, im VARCHAR (50), op TEXT (50), kol VARCHAR (50), cen VARCHAR (50))";
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        command.ExecuteNonQuery();


                        //----
                        string query01 = "ALTER TABLE Товары DROP COLUMN Код";
                        OleDbCommand command01 = new OleDbCommand(query01, myConnection);
                        command01.ExecuteNonQuery();

                        string query0 = "ALTER TABLE Товары ADD COLUMN Код counter";
                        OleDbCommand command0 = new OleDbCommand(query0, myConnection);
                        command0.ExecuteNonQuery();
                        //-----


                        string query = "SELECT COUNT(*) FROM Товары";
                        Console.WriteLine(query);
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        a = command.ExecuteScalar().ToString();
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM " + Program.courseName;          
            OleDbCommand command = new OleDbCommand(query, myConnection);
            string i = command.ExecuteScalar().ToString();

            string query0 = "UPDATE processing SET val = " + i + " WHERE field = 'total'";
            OleDbCommand command0 = new OleDbCommand(query0, myConnection);
            command0.ExecuteNonQuery();


            string query2 = "SELECT val FROM processing WHERE field = 'solved'";
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            string trueCount = command2.ExecuteScalar().ToString();
            Console.WriteLine("trueCoiynt " + trueCount);

            for (int j = 1; j <= Convert.ToInt32(i); j++)
            {
                Program.cod = j;
                /*string query01 = "UPDATE processing SET val = " + j + " WHERE field = 'cod'";
                OleDbCommand command01 = new OleDbCommand(query01, myConnection);
                command01.ExecuteNonQuery();*/




                string query1 = "SELECT type FROM " + Program.courseName + " WHERE Код = " + j;
                OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                string type = command1.ExecuteScalar().ToString();

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
