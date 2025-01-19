namespace iLearning
{
    partial class createCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonAddLection = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCreateCourse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.courseName.Location = new System.Drawing.Point(203, 48);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(245, 34);
            this.courseName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название курса";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonAddTest);
            this.panel1.Controls.Add(this.buttonAddLection);
            this.panel1.Location = new System.Drawing.Point(46, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 399);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(14, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 311);
            this.panel2.TabIndex = 5;
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(9)))));
            this.buttonAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTest.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonAddTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.buttonAddTest.Location = new System.Drawing.Point(287, 18);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(246, 39);
            this.buttonAddTest.TabIndex = 4;
            this.buttonAddTest.Text = "Добавить тест";
            this.buttonAddTest.UseVisualStyleBackColor = false;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonAddLection
            // 
            this.buttonAddLection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(9)))));
            this.buttonAddLection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLection.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonAddLection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.buttonAddLection.Location = new System.Drawing.Point(3, 18);
            this.buttonAddLection.Name = "buttonAddLection";
            this.buttonAddLection.Size = new System.Drawing.Size(246, 39);
            this.buttonAddLection.TabIndex = 3;
            this.buttonAddLection.Text = "Добавить лекцию";
            this.buttonAddLection.UseVisualStyleBackColor = false;
            this.buttonAddLection.Click += new System.EventHandler(this.buttonAddLection_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(9)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.buttonSave.Location = new System.Drawing.Point(294, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(246, 39);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(9)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.buttonExit.Location = new System.Drawing.Point(10, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(246, 39);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCreateCourse
            // 
            this.buttonCreateCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(23)))), ((int)(((byte)(9)))));
            this.buttonCreateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateCourse.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.buttonCreateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.buttonCreateCourse.Location = new System.Drawing.Point(454, 45);
            this.buttonCreateCourse.Name = "buttonCreateCourse";
            this.buttonCreateCourse.Size = new System.Drawing.Size(246, 39);
            this.buttonCreateCourse.TabIndex = 7;
            this.buttonCreateCourse.Text = "Создать курс";
            this.buttonCreateCourse.UseVisualStyleBackColor = false;
            this.buttonCreateCourse.Click += new System.EventHandler(this.buttonCreateCourse_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(46, 563);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 59);
            this.panel3.TabIndex = 8;
            // 
            // createCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(86)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1043, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonCreateCourse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseName);
            this.Name = "createCourse";
            this.Text = "createCourse";
            this.Load += new System.EventHandler(this.createCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonAddLection;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCreateCourse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}