namespace PhotomaxForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel2 = new System.Windows.Forms.Panel();
            this.midPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.midPanel2 = new System.Windows.Forms.Panel();
            this.bottonPanel2 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.bottonPanel1 = new System.Windows.Forms.Panel();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.textBox2option1 = new System.Windows.Forms.TextBox();
            this.textBox2option2 = new System.Windows.Forms.TextBox();
            this.textBox2option3 = new System.Windows.Forms.TextBox();
            this.textBox2option4 = new System.Windows.Forms.TextBox();
            this.checkBox2option1 = new System.Windows.Forms.CheckBox();
            this.checkBox2option2 = new System.Windows.Forms.CheckBox();
            this.checkBox2option3 = new System.Windows.Forms.CheckBox();
            this.checkBox2option4 = new System.Windows.Forms.CheckBox();
            this.label2intro = new System.Windows.Forms.Label();
            this.topPanel2.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.midPanel2.SuspendLayout();
            this.bottonPanel2.SuspendLayout();
            this.bottonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel2
            // 
            this.topPanel2.Controls.Add(this.label2intro);
            this.topPanel2.Location = new System.Drawing.Point(12, 17);
            this.topPanel2.Name = "topPanel2";
            this.topPanel2.Size = new System.Drawing.Size(776, 38);
            this.topPanel2.TabIndex = 0;
            this.topPanel2.Visible = false;
            // 
            // midPanel
            // 
            this.midPanel.Controls.Add(this.label1);
            this.midPanel.Location = new System.Drawing.Point(15, 57);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(776, 273);
            this.midPanel.TabIndex = 1;
            this.midPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to PhotoMax";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // midPanel2
            // 
            this.midPanel2.Controls.Add(this.checkBox2option4);
            this.midPanel2.Controls.Add(this.checkBox2option3);
            this.midPanel2.Controls.Add(this.checkBox2option2);
            this.midPanel2.Controls.Add(this.checkBox2option1);
            this.midPanel2.Controls.Add(this.textBox2option4);
            this.midPanel2.Controls.Add(this.textBox2option3);
            this.midPanel2.Controls.Add(this.textBox2option2);
            this.midPanel2.Controls.Add(this.textBox2option1);
            this.midPanel2.Location = new System.Drawing.Point(12, 58);
            this.midPanel2.Name = "midPanel2";
            this.midPanel2.Size = new System.Drawing.Size(773, 272);
            this.midPanel2.TabIndex = 1;
            this.midPanel2.Visible = false;
            this.midPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // bottonPanel2
            // 
            this.bottonPanel2.Controls.Add(this.btnNext2);
            this.bottonPanel2.Controls.Add(this.btnBack2);
            this.bottonPanel2.Location = new System.Drawing.Point(15, 336);
            this.bottonPanel2.Name = "bottonPanel2";
            this.bottonPanel2.Size = new System.Drawing.Size(776, 32);
            this.bottonPanel2.TabIndex = 3;
            this.bottonPanel2.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(357, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BntStart_Click);
            // 
            // bottonPanel1
            // 
            this.bottonPanel1.Controls.Add(this.btnStart);
            this.bottonPanel1.Location = new System.Drawing.Point(15, 340);
            this.bottonPanel1.Name = "bottonPanel1";
            this.bottonPanel1.Size = new System.Drawing.Size(773, 28);
            this.bottonPanel1.TabIndex = 2;
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(563, 3);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 3;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(167, 3);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(75, 23);
            this.btnBack2.TabIndex = 4;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            // 
            // textBox2option1
            // 
            this.textBox2option1.Location = new System.Drawing.Point(197, 28);
            this.textBox2option1.Name = "textBox2option1";
            this.textBox2option1.Size = new System.Drawing.Size(255, 20);
            this.textBox2option1.TabIndex = 0;
            this.textBox2option1.Text = "1";
            this.textBox2option1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2option2
            // 
            this.textBox2option2.Location = new System.Drawing.Point(197, 82);
            this.textBox2option2.Name = "textBox2option2";
            this.textBox2option2.Size = new System.Drawing.Size(255, 20);
            this.textBox2option2.TabIndex = 1;
            this.textBox2option2.Text = "2";
            this.textBox2option2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2option3
            // 
            this.textBox2option3.Location = new System.Drawing.Point(197, 138);
            this.textBox2option3.Name = "textBox2option3";
            this.textBox2option3.Size = new System.Drawing.Size(255, 20);
            this.textBox2option3.TabIndex = 2;
            this.textBox2option3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2option4
            // 
            this.textBox2option4.Location = new System.Drawing.Point(197, 197);
            this.textBox2option4.Name = "textBox2option4";
            this.textBox2option4.Size = new System.Drawing.Size(255, 20);
            this.textBox2option4.TabIndex = 3;
            this.textBox2option4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox2option1
            // 
            this.checkBox2option1.AutoSize = true;
            this.checkBox2option1.Location = new System.Drawing.Point(479, 31);
            this.checkBox2option1.Name = "checkBox2option1";
            this.checkBox2option1.Size = new System.Drawing.Size(15, 14);
            this.checkBox2option1.TabIndex = 4;
            this.checkBox2option1.UseVisualStyleBackColor = true;
            // 
            // checkBox2option2
            // 
            this.checkBox2option2.AutoSize = true;
            this.checkBox2option2.Location = new System.Drawing.Point(479, 84);
            this.checkBox2option2.Name = "checkBox2option2";
            this.checkBox2option2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2option2.TabIndex = 5;
            this.checkBox2option2.UseVisualStyleBackColor = true;
            // 
            // checkBox2option3
            // 
            this.checkBox2option3.AutoSize = true;
            this.checkBox2option3.Location = new System.Drawing.Point(479, 140);
            this.checkBox2option3.Name = "checkBox2option3";
            this.checkBox2option3.Size = new System.Drawing.Size(15, 14);
            this.checkBox2option3.TabIndex = 6;
            this.checkBox2option3.UseVisualStyleBackColor = true;
            this.checkBox2option3.CheckedChanged += new System.EventHandler(this.CheckBox2option3_CheckedChanged);
            // 
            // checkBox2option4
            // 
            this.checkBox2option4.AutoSize = true;
            this.checkBox2option4.Location = new System.Drawing.Point(479, 199);
            this.checkBox2option4.Name = "checkBox2option4";
            this.checkBox2option4.Size = new System.Drawing.Size(15, 14);
            this.checkBox2option4.TabIndex = 7;
            this.checkBox2option4.UseVisualStyleBackColor = true;
            // 
            // label2intro
            // 
            this.label2intro.AutoSize = true;
            this.label2intro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2intro.Location = new System.Drawing.Point(330, 0);
            this.label2intro.Name = "label2intro";
            this.label2intro.Size = new System.Drawing.Size(62, 22);
            this.label2intro.TabIndex = 0;
            this.label2intro.Text = "Empty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.midPanel2);
            this.Controls.Add(this.bottonPanel2);
            this.Controls.Add(this.bottonPanel1);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel2.ResumeLayout(false);
            this.topPanel2.PerformLayout();
            this.midPanel.ResumeLayout(false);
            this.midPanel.PerformLayout();
            this.midPanel2.ResumeLayout(false);
            this.midPanel2.PerformLayout();
            this.bottonPanel2.ResumeLayout(false);
            this.bottonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel2;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel midPanel2;
        private System.Windows.Forms.Panel bottonPanel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel bottonPanel1;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.CheckBox checkBox2option4;
        private System.Windows.Forms.CheckBox checkBox2option3;
        private System.Windows.Forms.CheckBox checkBox2option2;
        private System.Windows.Forms.CheckBox checkBox2option1;
        private System.Windows.Forms.TextBox textBox2option4;
        private System.Windows.Forms.TextBox textBox2option3;
        private System.Windows.Forms.TextBox textBox2option2;
        private System.Windows.Forms.TextBox textBox2option1;
        private System.Windows.Forms.Label label2intro;
    }
}

