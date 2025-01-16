﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLearning
{
    public partial class formSequence : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;

        bool trueFlag = false;
        bool flag = false;
        TextBox txb;
        TextBox pretxb;
        Color one = Color.Green;
        Color two = Color.Yellow;
        Color three = Color.Blue;
        Color four = Color.Orange;

        Color color;
        Color sysColor;

        Dictionary<string, Color> map = new Dictionary<string, Color>();
        

        List<int> colors = new List<int>();


        int[] mas1;
        int[] mas2;
        public formSequence()
        {
            InitializeComponent();


            myConnection = new OleDbConnection(connectString);
            myConnection.Open();


            map = new Dictionary<string, Color>(){
                { "Green", Color.Green},
                { "Yellow", Color.Yellow},
                { "Blue", Color.Blue},
                { "Orange", Color.Orange},
            };


        }

        private void formSequence_Load(object sender, EventArgs e)
        {
            sysColor = ask1.BackColor;

            Dictionary<int, string> map = new Dictionary<int, string>();
            Dictionary<int, string> map2 = new Dictionary<int, string>();


            string query0 = "SELECT question FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command0 = new OleDbCommand(query0, myConnection);
            question.Text = command0.ExecuteScalar().ToString();

            string query1 = "SELECT askvar1 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            string askvar1 = command1.ExecuteScalar().ToString();

            string query2 = "SELECT askvar2 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            string askvar2 = command2.ExecuteScalar().ToString();

            string query3 = "SELECT askvar3 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command3 = new OleDbCommand(query3, myConnection);
            string askvar3 = command3.ExecuteScalar().ToString();

            string query4 = "SELECT askvar4 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command4 = new OleDbCommand(query4, myConnection);
            string askvar4 = command4.ExecuteScalar().ToString();


            string query01 = "SELECT answvar1 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command01 = new OleDbCommand(query01, myConnection);
            string answvar1 = command01.ExecuteScalar().ToString();

            string query02 = "SELECT answvar2 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command02 = new OleDbCommand(query02, myConnection);
            string answvar2 = command02.ExecuteScalar().ToString();

            string query03 = "SELECT answvar3 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command03 = new OleDbCommand(query03, myConnection);
            string answvar3 = command03.ExecuteScalar().ToString();

            string query04 = "SELECT answvar4 FROM " + Program.courseName + " WHERE Код = " + Program.cod;
            OleDbCommand command04 = new OleDbCommand(query04, myConnection);
            string answvar4 = command04.ExecuteScalar().ToString();



            map = new Dictionary<int, string>(){
                { 1, askvar1},
                { 2, askvar2},
                { 3, askvar3},
                { 4, askvar4},
            };            

            int count = 0;
            mas1 = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int a = rnd.Next(1, 5);
                for (int j = 0; j < 4; j++)
                {
                    if (a != mas1[j])
                        count++;
                    else { i--; break; }
                    if (count == 4)
                    {
                        mas1[i] = a;
                        count = 0;
                    }
                }
            }


            Thread.Sleep(15);   // для другой случайности 2 массива


            map2 = new Dictionary<int, string>(){
                { 1, answvar1},
                { 2, answvar2},
                { 3, answvar3},
                { 4, answvar4},
            };

            int count2 = 0;
            mas2 = new int[4];
            Random rnd2 = new Random();
            for (int i = 0; i < 4; i++)
            {
                int a2 = rnd2.Next(1, 5);
                for (int j = 0; j < 4; j++)
                {
                    if (a2 != mas2[j])
                        count2++;
                    else { i--; break; }
                    if (count2 == 4)
                    {
                        mas2[i] = a2;
                        count2 = 0;
                    }
                }
            }

            ask1.Text = map[mas1[0]];
            ask2.Text = map[mas1[1]];
            ask3.Text = map[mas1[2]];
            ask4.Text = map[mas1[3]];


            answer1.Text = map2[mas2[0]];
            answer2.Text = map2[mas2[1]];
            answer3.Text = map2[mas2[2]];
            answer4.Text = map2[mas2[3]];
        }

        private void getColor(int answer, Color nowColor)
        {

            try
            {
                if (nowColor != sysColor)
                    map.Add(nowColor.ToString(), nowColor);
            }
            catch { }

            string key = map.First().Key;
            color = map.First().Value;
            if (answer == 1)
                map.Remove(key);

            
            if (map.Count == 0) {
                trueFlag = true;    // Проверка на заполнение всего
            };


            if (ask1.BackColor == color && answer == 0)
                ask1.BackColor = sysColor;
            if (ask2.BackColor == color && answer == 0)
                ask2.BackColor = sysColor;
            if (ask3.BackColor == color && answer == 0)
                ask3.BackColor = sysColor;
            if (ask4.BackColor == color && answer == 0)
                ask4.BackColor = sysColor;

            if (answer4.BackColor == color && answer == 0)
                answer4.BackColor = sysColor;
            if (answer3.BackColor == color && answer == 0)
                answer3.BackColor = sysColor;
            if (answer2.BackColor == color && answer == 0)
                answer2.BackColor = sysColor;
            if (answer1.BackColor == color && answer == 0)
                answer1.BackColor = sysColor;

        }

        private void processing(object sender, EventArgs e)
        {

            if (flag == false && txb.Tag.ToString() == "answer")
            {
                txb.BackColor = sysColor;
                flag = false;
            }
            else if (flag == false && txb.Tag.ToString() == "ask")
            {
                getColor(0, txb.BackColor);
                txb.BackColor = color;
                flag = true;
                pretxb = txb;
            }
            else if (flag == true && txb.Tag.ToString() == "answer")
            {
                getColor(1, txb.BackColor);
                txb.BackColor = color;
                flag = false;

            }
            else if (flag == true && txb.Tag.ToString() == "ask")
            {
                pretxb.BackColor = sysColor;
                getColor(0, txb.BackColor);
                txb.BackColor = color;
                flag = true;
                pretxb = txb;

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);         
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            txb = (TextBox)sender;
            processing(sender, e);
        }
               

        private void button2_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            this.Close();
        }

        private int Checking() {
                
            Color[] colors1;
            colors1 = new Color[4];

            Color[] colors2;
            colors2 = new Color[4];

            colors1[0] = ask1.BackColor;
            colors1[1] = ask2.BackColor;
            colors1[2] = ask3.BackColor;
            colors1[3] = ask4.BackColor;

            colors2[0] = answer1.BackColor;
            colors2[1] = answer2.BackColor;
            colors2[2] = answer3.BackColor;
            colors2[3] = answer4.BackColor;

            int points = 0;
            for (int i = 1; i <= 4; i++)
            {
                if (colors1[Array.IndexOf(mas1, i)] == colors2[Array.IndexOf(mas2, i)])
                    points++;
            }
            if (points > 3)
                return 1;
            else return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query2 = "SELECT val FROM processing WHERE field = 'solved'";
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            string trueCount = command2.ExecuteScalar().ToString();

            try
            {
                Convert.ToInt32(trueCount);
            }
            catch
            {
                trueCount = "0";
            }


            if (trueFlag)
            {
                int a = Checking();

                if (a == 1)
                {
                    int newTrueCount = Convert.ToInt32(trueCount);
                    newTrueCount++;

                    string query0 = "UPDATE processing SET val = " + newTrueCount + " WHERE field = 'solved'";
                    OleDbCommand command0 = new OleDbCommand(query0, myConnection);
                    command0.ExecuteNonQuery();
                }                            
            }
            this.Close();
        }               
    }
}
