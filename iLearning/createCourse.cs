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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iLearning
{
    public partial class createCourse : Form
    {

        public static string dbConnectionString = @"Data Source=Database.db;Version=3;New=False;Compress=True;";
        System.Data.SQLite.SQLiteConnection sqliteCon = new System.Data.SQLite.SQLiteConnection(dbConnectionString);

        int x = 30;
        int y = 30;
        int count = 0;

        bool thisTest = false;
        string comText = "";

        public Panel[] panel = new Panel[99];
        public System.Windows.Forms.TextBox[] txtbxQws = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx1 = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx2 = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx3 = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx4 = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx5 = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx6 = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx7 = new System.Windows.Forms.TextBox[99];
        public System.Windows.Forms.TextBox[] txtbx8 = new System.Windows.Forms.TextBox[99];
        public RichTextBox[] richtextbox = new RichTextBox[99];

        public System.Windows.Forms.ComboBox[] comBox = new System.Windows.Forms.ComboBox[99];



        public createCourse()
        {
            InitializeComponent();

            sqliteCon.Open();
        }

        private void buttonCreateCourse_Click(object sender, EventArgs e)
        {


            string query = "SELECT course FROM courses WHERE course = '" + courseName.Text + "'";
            SQLiteCommand command = new SQLiteCommand(query, sqliteCon);
            SQLiteDataReader reader = command.ExecuteReader();


            string course = "";

            foreach (DbDataRecord record in reader)
            {
                course = record[0].ToString();
            }

            if (course == "")
            {
                string createTable = "CREATE TABLE '" + courseName.Text + "' (Код INTEGER NOT NULL UNIQUE, num INTEGER, type TEXT, question TEXT, trueanswer TEXT, answer1 TEXT, answer2 TEXT, answer3 TEXT, askvar1 TEXT, askvar2 TEXT, askvar3 TEXT, askvar4 TEXT, answvar1 TEXT, answvar2 TEXT, answvar3 TEXT, answvar4 TEXT, PRIMARY KEY(Код))";
                SQLiteCommand command0 = new SQLiteCommand(createTable, sqliteCon);
                command0.ExecuteNonQuery();

                string createTable2 = "CREATE TABLE 'L_" + courseName.Text + "' (Код INTEGER NOT NULL UNIQUE, type TEXT, text TEXT, PRIMARY KEY(Код))";
                SQLiteCommand command2 = new SQLiteCommand(createTable2, sqliteCon);
                command2.ExecuteNonQuery();

                /*string createTable3 = "CREATE TABLE 'U_" + courseName.Text + "' (id TEXT, text TEXT, PRIMARY KEY(Код))";
                SQLiteCommand command4 = new SQLiteCommand(createTable3, sqliteCon);
                command4.ExecuteNonQuery();*/

                string insertTable = "INSERT INTO Courses (Course) VALUES ('" + courseName.Text + "')";
                SQLiteCommand command1 = new SQLiteCommand(insertTable, sqliteCon);
                command1.ExecuteNonQuery();

                string updateQuery = "UPDATE users SET course = '" + courseName.Text + "' WHERE id = '" + Program.id + "'";                
                SQLiteCommand command3 = new SQLiteCommand(updateQuery, sqliteCon);
                command3.ExecuteNonQuery();

                panel1.Visible = true;
            }
            else
            {

            }


        }

        private void buttonAddLection_Click(object sender, EventArgs e)
        {
            
            save();

            thisTest = false;

            panel[count] = new Panel();

            panel[count].Location = new Point(x, y);
            panel[count].Size = new Size(861, 220);
            panel[count].AutoSize = false;
            panel[count].Tag = count;


            panel[count].BackColor = Color.LightGreen;
            // pan[i].BackColor = Color.FromArgb(255, 202, 134);



            richtextbox[count] = new RichTextBox();
            richtextbox[count].Location = new Point(27, 15);
            richtextbox[count].Size = new Size(803, 187);
            richtextbox[count].Text = "Введите текст лекции";
            richtextbox[count].ForeColor = Color.LightGray;
            richtextbox[count].AutoSize = false;
            richtextbox[count].Tag = count;
            richtextbox[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            /*          richtextbox[count]
                      richtextbox[count]
                      richtextbox[count]*/


            /* t1[i] = new TextBox();
             t1[i].Location = new Point(61, 25);
             t1[i].Size = new Size(228, 28);
             t1[i].AutoSize = false;
             t1[i].Tag = i;
             t1[i].Text = dol;
             t1[i].ForeColor = Color.Black;
             t1[i].Font = new Font("Snap ITC", 12, FontStyle.Bold);
             t1[i].BackColor = Color.White;
             //t1[i].BackColor = Color.FromArgb(153, 255, 153);
             t1[i].ReadOnly = true;
             t1[i].Visible = true;


             t2[i] = new TextBox();
             t2[i].Location = new Point(38, 331);
             t2[i].Size = new Size(278, 28);
             t2[i].AutoSize = false;
             t2[i].Tag = i;
             t2[i].Text = fio;
             t2[i].ReadOnly = true;
             t2[i].BackColor = Color.White;
             //t2[i].BackColor = Color.FromArgb(153, 255, 153);
             t2[i].Font = new Font("Snap ITC", 12, FontStyle.Bold);




             p[i] = new PictureBox();
             p[i].Location = new Point(61, 63);
             p[i].Size = new Size(228, 244);
             p[i].AutoSize = false;
             p[i].Tag = i;
             p[i].SizeMode = PictureBoxSizeMode.Zoom;
             p[i].Click += prod;
             p[i].Load("img/" + fio + ".jpg");*/




            panel2.AutoScrollPosition = new Point(panel2.VerticalScroll.Minimum);

            panel2.Controls.Add(panel[count]);

            panel[count].Controls.Add(richtextbox[count]);

            y += 250;
            count++;

            panel2.AutoScrollPosition = new Point(panel2.VerticalScroll.Maximum);

        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {

            save();

            thisTest = true;

            panel[count] = new Panel();

            panel[count].Location = new Point(x, y);
            panel[count].Size = new Size(861, 220);
            panel[count].AutoSize = false;
            panel[count].Tag = count;


            panel[count].BackColor = Color.LightGreen;

            comBox[count] = new System.Windows.Forms.ComboBox();
            
            comBox[count].Text = "Выберите тип";
            comBox[count].Items.Add("choice");
            comBox[count].Items.Add("sequence");
            comBox[count].Items.Add("text");
            comBox[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            comBox[count].Tag = count;
            comBox[count].Location = new Point(12, 18);
            comBox[count].AutoSize = false;
            comBox[count].Size = new Size(166, 34);

            comBox[count].SelectedValueChanged += change;



            panel2.AutoScrollPosition = new Point(panel2.VerticalScroll.Minimum);



            panel2.Controls.Add(panel[count]);
            panel[count].Controls.Add(comBox[count]);


            panel2.AutoScrollPosition = new Point(panel2.VerticalScroll.Maximum);

            //comBox[count]
        }


        public void save()
        {
            if (count != 0 && thisTest == true)
            {
                string insertTable = "";
                if (comText == "choice")
                {
                    insertTable = "INSERT INTO '" + courseName.Text + "' (type, question, trueanswer, answer1, answer2, answer3) VALUES ('" + comText + "', '" + txtbxQws[count - 1].Text + "', '" + txtbx1[count - 1].Text + "', '" + txtbx2[count - 1].Text + "', '" + txtbx3[count - 1].Text + "', '" + txtbx4[count - 1].Text + "')";
                }
                if (comText == "sequence")
                {
                    insertTable = "INSERT INTO '" + courseName.Text + "' (type, question, askvar1, answvar1, askvar2, answvar2, askvar3, answvar3, askvar4, answvar4) VALUES ('" + comText + "', '" + txtbxQws[count - 1].Text + "', '" + txtbx1[count - 1].Text + "', '" + txtbx2[count - 1].Text + "', '" + txtbx3[count - 1].Text + "', '" + txtbx4[count - 1].Text + "', '" + txtbx5[count - 1].Text + "', '" + txtbx6[count - 1].Text + "', '" + txtbx7[count - 1].Text + "', '" + txtbx8[count - 1].Text + "')";
                }
                if (comText == "text")
                {
                    insertTable = "INSERT INTO '" + courseName.Text + "' (type, question, trueanswer) VALUES ('" + comText + "', '" + txtbxQws[count - 1].Text + "', '" + txtbx1[count - 1].Text + "')";
                }


                SQLiteCommand command1 = new SQLiteCommand(insertTable, sqliteCon);
                command1.ExecuteNonQuery();


                insertTable = "INSERT INTO 'L_" + courseName.Text + "' (type, text) VALUES ('T', '1')";
                SQLiteCommand command2 = new SQLiteCommand(insertTable, sqliteCon);
                command2.ExecuteNonQuery();

            }
            else if (count != 0 && thisTest == false)
            {
                string insertTable = "";
                insertTable = "INSERT INTO 'L_" + courseName.Text + "' (type, text) VALUES ('L', '" + richtextbox[count - 1].Text + "')";

                SQLiteCommand command1 = new SQLiteCommand(insertTable, sqliteCon);
                command1.ExecuteNonQuery();
            }


        }
        public void change(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32((sender as System.Windows.Forms.ComboBox).Tag);
            comText = (sender as System.Windows.Forms.ComboBox).Text;


            if (comText == "choice")
            {


                txtbxQws[count] = new System.Windows.Forms.TextBox();
                txtbxQws[count].Location = new Point(12, 110);
                txtbxQws[count].Size = new Size(288, 34);
                txtbxQws[count].AutoSize = false;
                txtbxQws[count].Tag = count;
                txtbxQws[count].Text = "Вопрос";
                txtbxQws[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx1[count] = new System.Windows.Forms.TextBox();
                txtbx1[count].Location = new Point(330, 110);
                txtbx1[count].Size = new Size(232, 34);
                txtbx1[count].AutoSize = false;
                txtbx1[count].Tag = count;
                txtbx1[count].Text = "Верный ответ";
                txtbx1[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx2[count] = new System.Windows.Forms.TextBox();
                txtbx2[count].Location = new Point(570, 110);
                txtbx2[count].Size = new Size(232, 34);
                txtbx2[count].AutoSize = false;
                txtbx2[count].Tag = count;
                txtbx2[count].Text = "Неверный ответ 1";
                txtbx2[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx3[count] = new System.Windows.Forms.TextBox();
                txtbx3[count].Location = new Point(330, 150);
                txtbx3[count].Size = new Size(232, 34);
                txtbx3[count].AutoSize = false;
                txtbx3[count].Tag = count;
                txtbx3[count].Text = "Неверный ответ 2";
                txtbx3[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx4[count] = new System.Windows.Forms.TextBox();
                txtbx4[count].Location = new Point(570, 150);
                txtbx4[count].Size = new Size(232, 34);
                txtbx4[count].AutoSize = false;
                txtbx4[count].Tag = count;
                txtbx4[count].Text = "Неверный ответ 3";
                txtbx4[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);



               
                panel[count].Controls.Add(txtbxQws[count]);
                panel[count].Controls.Add(txtbx1[count]);
                panel[count].Controls.Add(txtbx2[count]);
                panel[count].Controls.Add(txtbx3[count]);
                panel[count].Controls.Add(txtbx4[count]);

            }
            else if (comText == "sequence")
            {
                txtbxQws[count] = new System.Windows.Forms.TextBox();
                txtbxQws[count].Location = new Point(12, 110);
                txtbxQws[count].Size = new Size(288, 34);
                txtbxQws[count].AutoSize = false;
                txtbxQws[count].Tag = count;
                txtbxQws[count].Text = "Условие";
                txtbxQws[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx1[count] = new System.Windows.Forms.TextBox();
                txtbx1[count].Location = new Point(330, 30);
                txtbx1[count].Size = new Size(232, 34);
                txtbx1[count].AutoSize = false;
                txtbx1[count].Tag = count;
                txtbx1[count].Text = "Условие 1";
                txtbx1[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx2[count] = new System.Windows.Forms.TextBox();
                txtbx2[count].Location = new Point(570, 30);
                txtbx2[count].Size = new Size(232, 34);
                txtbx2[count].AutoSize = false;
                txtbx2[count].Tag = count;
                txtbx2[count].Text = "Значение 1";
                txtbx2[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx3[count] = new System.Windows.Forms.TextBox();
                txtbx3[count].Location = new Point(330, 70);
                txtbx3[count].Size = new Size(232, 34);
                txtbx3[count].AutoSize = false;
                txtbx3[count].Tag = count;
                txtbx3[count].Text = "Условие 2";
                txtbx3[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx4[count] = new System.Windows.Forms.TextBox();
                txtbx4[count].Location = new Point(570, 70);
                txtbx4[count].Size = new Size(232, 34);
                txtbx4[count].AutoSize = false;
                txtbx4[count].Tag = count;
                txtbx4[count].Text = "Значение 2";
                txtbx4[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx5[count] = new System.Windows.Forms.TextBox();
                txtbx5[count].Location = new Point(330, 110);
                txtbx5[count].Size = new Size(232, 34);
                txtbx5[count].AutoSize = false;
                txtbx5[count].Tag = count;
                txtbx5[count].Text = "Условие 3";
                txtbx5[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx6[count] = new System.Windows.Forms.TextBox();
                txtbx6[count].Location = new Point(570, 110);
                txtbx6[count].Size = new Size(232, 34);
                txtbx6[count].AutoSize = false;
                txtbx6[count].Tag = count;
                txtbx6[count].Text = "Значение 3";
                txtbx6[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx7[count] = new System.Windows.Forms.TextBox();
                txtbx7[count].Location = new Point(330, 150);
                txtbx7[count].Size = new Size(232, 34);
                txtbx7[count].AutoSize = false;
                txtbx7[count].Tag = count;
                txtbx7[count].Text = "Условие 4";
                txtbx7[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                txtbx8[count] = new System.Windows.Forms.TextBox();
                txtbx8[count].Location = new Point(570, 150);
                txtbx8[count].Size = new Size(232, 34);
                txtbx8[count].AutoSize = false;
                txtbx8[count].Tag = count;
                txtbx8[count].Text = "Значение 4";
                txtbx8[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);


                panel[count].Controls.Add(txtbxQws[count]);
                panel[count].Controls.Add(txtbx1[count]);
                panel[count].Controls.Add(txtbx2[count]);
                panel[count].Controls.Add(txtbx3[count]);
                panel[count].Controls.Add(txtbx4[count]);
                panel[count].Controls.Add(txtbx5[count]);
                panel[count].Controls.Add(txtbx6[count]);
                panel[count].Controls.Add(txtbx7[count]);
                panel[count].Controls.Add(txtbx8[count]);

            }
            else if (comText == "text")
            {
                txtbx1[count] = new System.Windows.Forms.TextBox();
                txtbx1[count].Location = new Point(12, 110);
                txtbx1[count].Size = new Size(288, 34);
                txtbx1[count].AutoSize = false;
                txtbx1[count].Tag = count;
                txtbx1[count].Text = "Пропущенное слово";
                txtbx1[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);

                /*     txtbx1[count] = new System.Windows.Forms.TextBox();
                     txtbx1[count].Location = new Point(12, 169);
                     txtbx1[count].Size = new Size(288, 34);
                     txtbx1[count].AutoSize = false;
                     txtbx1[count].Tag = count;
                     txtbx1[count].Text = "Пропущенное слово";
                     txtbx1[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);*/

                txtbxQws[count] = new System.Windows.Forms.TextBox();
                txtbxQws[count].Location = new Point(314, 13);
                txtbxQws[count].Multiline = true;
                txtbxQws[count].Size = new Size(534, 190);
                txtbxQws[count].AutoSize = false;
                txtbxQws[count].Tag = count;
                txtbxQws[count].Text = "Текст с пропущенным словом";
                txtbxQws[count].Font = new Font("Comic Sans MS", 14, FontStyle.Bold);


                panel[count].Controls.Add(txtbxQws[count]);
                panel[count].Controls.Add(txtbx1[count]);
                //panel[count].Controls.Add(txtbx2[count]);
             
            }
           

            y += 250;
            count++;
        }

        private void createCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
