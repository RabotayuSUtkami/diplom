namespace iLearning
{
    partial class movingElement
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.upBut = new System.Windows.Forms.Button();
            this.downBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 37);
            this.textBox1.TabIndex = 0;
            // 
            // upBut
            // 
            this.upBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upBut.Location = new System.Drawing.Point(238, -1);
            this.upBut.Name = "upBut";
            this.upBut.Size = new System.Drawing.Size(20, 20);
            this.upBut.TabIndex = 1;
            this.upBut.Text = "⮝";
            this.upBut.UseVisualStyleBackColor = true;
            // 
            // downBut
            // 
            this.downBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downBut.Location = new System.Drawing.Point(238, 18);
            this.downBut.Name = "downBut";
            this.downBut.Size = new System.Drawing.Size(20, 20);
            this.downBut.TabIndex = 2;
            this.downBut.Text = "⮟";
            this.downBut.UseVisualStyleBackColor = true;
            // 
            // movingElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.downBut);
            this.Controls.Add(this.upBut);
            this.Controls.Add(this.textBox1);
            this.Name = "movingElement";
            this.Size = new System.Drawing.Size(255, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button upBut;
        private System.Windows.Forms.Button downBut;
    }
}
