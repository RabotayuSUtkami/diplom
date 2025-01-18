namespace iLearning
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.butSignIn = new System.Windows.Forms.Button();
            this.butSignUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.login.Location = new System.Drawing.Point(65, 56);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(218, 34);
            this.login.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.pass.Location = new System.Drawing.Point(65, 105);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(218, 34);
            this.pass.TabIndex = 1;
            // 
            // butSignIn
            // 
            this.butSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butSignIn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.butSignIn.Location = new System.Drawing.Point(65, 183);
            this.butSignIn.Name = "butSignIn";
            this.butSignIn.Size = new System.Drawing.Size(218, 42);
            this.butSignIn.TabIndex = 2;
            this.butSignIn.Text = "Войти";
            this.butSignIn.UseVisualStyleBackColor = true;
            this.butSignIn.Click += new System.EventHandler(this.butSignIn_Click);
            // 
            // butSignUp
            // 
            this.butSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butSignUp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.butSignUp.Location = new System.Drawing.Point(65, 279);
            this.butSignUp.Name = "butSignUp";
            this.butSignUp.Size = new System.Drawing.Size(218, 42);
            this.butSignUp.TabIndex = 3;
            this.butSignUp.Text = "Зарегистрироваться";
            this.butSignUp.UseVisualStyleBackColor = true;
            this.butSignUp.Click += new System.EventHandler(this.butSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.butCheckBox);
            this.panel1.Controls.Add(this.butSignUp);
            this.panel1.Controls.Add(this.butSignIn);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.login);
            this.panel1.Location = new System.Drawing.Point(114, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 362);
            this.panel1.TabIndex = 5;
            // 
            // butCheckBox
            // 
            this.butCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.butCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.butCheckBox.Location = new System.Drawing.Point(65, 231);
            this.butCheckBox.Name = "butCheckBox";
            this.butCheckBox.Size = new System.Drawing.Size(218, 42);
            this.butCheckBox.TabIndex = 6;
            this.butCheckBox.Text = "Войти по ID";
            this.butCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butCheckBox.UseVisualStyleBackColor = true;
            this.butCheckBox.CheckedChanged += new System.EventHandler(this.butCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 530);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button butSignIn;
        private System.Windows.Forms.Button butSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox butCheckBox;
    }
}

