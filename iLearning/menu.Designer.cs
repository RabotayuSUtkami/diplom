namespace iLearning
{
    partial class menu
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
            this.variant2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variant2
            // 
            this.variant2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variant2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.variant2.Location = new System.Drawing.Point(43, 61);
            this.variant2.Margin = new System.Windows.Forms.Padding(20);
            this.variant2.MinimumSize = new System.Drawing.Size(240, 100);
            this.variant2.Name = "variant2";
            this.variant2.Size = new System.Drawing.Size(361, 100);
            this.variant2.TabIndex = 2;
            this.variant2.Text = "Лекции";
            this.variant2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button1.Location = new System.Drawing.Point(43, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(20);
            this.button1.MinimumSize = new System.Drawing.Size(240, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Задачи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button2.Location = new System.Drawing.Point(43, 301);
            this.button2.Margin = new System.Windows.Forms.Padding(20);
            this.button2.MinimumSize = new System.Drawing.Size(240, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(361, 100);
            this.button2.TabIndex = 4;
            this.button2.Text = "Настройки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button3.Location = new System.Drawing.Point(43, 423);
            this.button3.Margin = new System.Windows.Forms.Padding(20);
            this.button3.MinimumSize = new System.Drawing.Size(240, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(361, 100);
            this.button3.TabIndex = 5;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 642);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.variant2);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button variant2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}