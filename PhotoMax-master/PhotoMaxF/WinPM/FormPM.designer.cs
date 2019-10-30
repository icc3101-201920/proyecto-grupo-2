namespace WinPM
{
    partial class FormPM
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
            this.label2intro = new System.Windows.Forms.Label();
            this.midPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bottonPanel2 = new System.Windows.Forms.Panel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.bottonPanel1 = new System.Windows.Forms.Panel();
            this.Topanel3Op1 = new System.Windows.Forms.Panel();
            this.label3Option1 = new System.Windows.Forms.Label();
            this.midPanel2 = new System.Windows.Forms.Panel();
            this.btn2option2 = new System.Windows.Forms.Button();
            this.btn2option3 = new System.Windows.Forms.Button();
            this.btn2option4 = new System.Windows.Forms.Button();
            this.btn2Option1 = new System.Windows.Forms.Button();
            this.midPanel3Option1 = new System.Windows.Forms.Panel();
            this.textBox3EnterPath = new System.Windows.Forms.TextBox();
            this.btn3EnterPath = new System.Windows.Forms.Button();
            this.MidPanel4Menu = new System.Windows.Forms.Panel();
            this.TopPanel4Menu = new System.Windows.Forms.Panel();
            this.topPanel2.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.bottonPanel2.SuspendLayout();
            this.bottonPanel1.SuspendLayout();
            this.Topanel3Op1.SuspendLayout();
            this.midPanel2.SuspendLayout();
            this.midPanel3Option1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel2
            // 
            this.topPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.topPanel2.Controls.Add(this.Topanel3Op1);
            this.topPanel2.Controls.Add(this.label2intro);
            this.topPanel2.Location = new System.Drawing.Point(12, 17);
            this.topPanel2.Name = "topPanel2";
            this.topPanel2.Size = new System.Drawing.Size(776, 38);
            this.topPanel2.TabIndex = 0;
            this.topPanel2.Visible = false;
            // 
            // label2intro
            // 
            this.label2intro.AutoSize = true;
            this.label2intro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2intro.Location = new System.Drawing.Point(310, 15);
            this.label2intro.Name = "label2intro";
            this.label2intro.Size = new System.Drawing.Size(154, 22);
            this.label2intro.TabIndex = 0;
            this.label2intro.Text = "Choose an option";
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
            // bottonPanel2
            // 
            this.bottonPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bottonPanel2.Controls.Add(this.btnBack2);
            this.bottonPanel2.Location = new System.Drawing.Point(15, 336);
            this.bottonPanel2.Name = "bottonPanel2";
            this.bottonPanel2.Size = new System.Drawing.Size(776, 32);
            this.bottonPanel2.TabIndex = 3;
            this.bottonPanel2.Visible = false;
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
            // Topanel3Op1
            // 
            this.Topanel3Op1.Controls.Add(this.TopPanel4Menu);
            this.Topanel3Op1.Controls.Add(this.label3Option1);
            this.Topanel3Op1.Location = new System.Drawing.Point(3, 0);
            this.Topanel3Op1.Name = "Topanel3Op1";
            this.Topanel3Op1.Size = new System.Drawing.Size(773, 38);
            this.Topanel3Op1.TabIndex = 1;
            this.Topanel3Op1.Visible = false;
            // 
            // label3Option1
            // 
            this.label3Option1.AutoSize = true;
            this.label3Option1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Option1.Location = new System.Drawing.Point(329, 15);
            this.label3Option1.Name = "label3Option1";
            this.label3Option1.Size = new System.Drawing.Size(94, 22);
            this.label3Option1.TabIndex = 0;
            this.label3Option1.Text = "Enter Path";
            this.label3Option1.Visible = false;
            // 
            // midPanel2
            // 
            this.midPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.midPanel2.Controls.Add(this.midPanel3Option1);
            this.midPanel2.Controls.Add(this.btn2Option1);
            this.midPanel2.Controls.Add(this.btn2option4);
            this.midPanel2.Controls.Add(this.btn2option3);
            this.midPanel2.Controls.Add(this.btn2option2);
            this.midPanel2.Location = new System.Drawing.Point(15, 58);
            this.midPanel2.Name = "midPanel2";
            this.midPanel2.Size = new System.Drawing.Size(773, 272);
            this.midPanel2.TabIndex = 1;
            this.midPanel2.Visible = false;
            this.midPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btn2option2
            // 
            this.btn2option2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2option2.Location = new System.Drawing.Point(69, 74);
            this.btn2option2.Name = "btn2option2";
            this.btn2option2.Size = new System.Drawing.Size(648, 50);
            this.btn2option2.TabIndex = 1;
            this.btn2option2.Text = "not implemented";
            this.btn2option2.UseVisualStyleBackColor = true;
            // 
            // btn2option3
            // 
            this.btn2option3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2option3.Location = new System.Drawing.Point(69, 130);
            this.btn2option3.Name = "btn2option3";
            this.btn2option3.Size = new System.Drawing.Size(648, 50);
            this.btn2option3.TabIndex = 2;
            this.btn2option3.Text = "not implemented";
            this.btn2option3.UseVisualStyleBackColor = true;
            this.btn2option3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn2option4
            // 
            this.btn2option4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2option4.Location = new System.Drawing.Point(69, 186);
            this.btn2option4.Name = "btn2option4";
            this.btn2option4.Size = new System.Drawing.Size(648, 50);
            this.btn2option4.TabIndex = 3;
            this.btn2option4.Text = "not implemented";
            this.btn2option4.UseVisualStyleBackColor = true;
            // 
            // btn2Option1
            // 
            this.btn2Option1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Option1.Location = new System.Drawing.Point(69, 18);
            this.btn2Option1.Name = "btn2Option1";
            this.btn2Option1.Size = new System.Drawing.Size(648, 50);
            this.btn2Option1.TabIndex = 4;
            this.btn2Option1.Text = "Enter path";
            this.btn2Option1.UseVisualStyleBackColor = true;
            this.btn2Option1.Click += new System.EventHandler(this.btn2Option1_Click);
            // 
            // midPanel3Option1
            // 
            this.midPanel3Option1.Controls.Add(this.MidPanel4Menu);
            this.midPanel3Option1.Controls.Add(this.btn3EnterPath);
            this.midPanel3Option1.Controls.Add(this.textBox3EnterPath);
            this.midPanel3Option1.Location = new System.Drawing.Point(3, 3);
            this.midPanel3Option1.Name = "midPanel3Option1";
            this.midPanel3Option1.Size = new System.Drawing.Size(773, 266);
            this.midPanel3Option1.TabIndex = 5;
            this.midPanel3Option1.Visible = false;
            this.midPanel3Option1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // textBox3EnterPath
            // 
            this.textBox3EnterPath.Location = new System.Drawing.Point(164, 111);
            this.textBox3EnterPath.Name = "textBox3EnterPath";
            this.textBox3EnterPath.Size = new System.Drawing.Size(439, 20);
            this.textBox3EnterPath.TabIndex = 0;
            this.textBox3EnterPath.Visible = false;
            this.textBox3EnterPath.TextChanged += new System.EventHandler(this.textBox3EnterPath_TextChanged);
            // 
            // btn3EnterPath
            // 
            this.btn3EnterPath.Location = new System.Drawing.Point(345, 144);
            this.btn3EnterPath.Name = "btn3EnterPath";
            this.btn3EnterPath.Size = new System.Drawing.Size(75, 23);
            this.btn3EnterPath.TabIndex = 1;
            this.btn3EnterPath.Text = "Enter";
            this.btn3EnterPath.UseVisualStyleBackColor = true;
            this.btn3EnterPath.Visible = false;
            this.btn3EnterPath.Click += new System.EventHandler(this.btn3EnterPath_Click);
            // 
            // MidPanel4Menu
            // 
            this.MidPanel4Menu.Location = new System.Drawing.Point(-3, -1);
            this.MidPanel4Menu.Name = "MidPanel4Menu";
            this.MidPanel4Menu.Size = new System.Drawing.Size(773, 267);
            this.MidPanel4Menu.TabIndex = 2;
            this.MidPanel4Menu.Visible = false;
            // 
            // TopPanel4Menu
            // 
            this.TopPanel4Menu.Location = new System.Drawing.Point(0, 0);
            this.TopPanel4Menu.Name = "TopPanel4Menu";
            this.TopPanel4Menu.Size = new System.Drawing.Size(773, 38);
            this.TopPanel4Menu.TabIndex = 1;
            // 
            // FormPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.midPanel2);
            this.Controls.Add(this.bottonPanel2);
            this.Controls.Add(this.bottonPanel1);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.topPanel2);
            this.Name = "FormPM";
            this.Text = "PhotoMax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel2.ResumeLayout(false);
            this.topPanel2.PerformLayout();
            this.midPanel.ResumeLayout(false);
            this.midPanel.PerformLayout();
            this.bottonPanel2.ResumeLayout(false);
            this.bottonPanel1.ResumeLayout(false);
            this.Topanel3Op1.ResumeLayout(false);
            this.Topanel3Op1.PerformLayout();
            this.midPanel2.ResumeLayout(false);
            this.midPanel3Option1.ResumeLayout(false);
            this.midPanel3Option1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel2;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bottonPanel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel bottonPanel1;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Label label2intro;
        private System.Windows.Forms.Panel Topanel3Op1;
        private System.Windows.Forms.Label label3Option1;
        private System.Windows.Forms.Panel midPanel2;
        private System.Windows.Forms.Button btn2Option1;
        private System.Windows.Forms.Button btn2option4;
        private System.Windows.Forms.Button btn2option3;
        private System.Windows.Forms.Button btn2option2;
        private System.Windows.Forms.Panel midPanel3Option1;
        private System.Windows.Forms.TextBox textBox3EnterPath;
        private System.Windows.Forms.Button btn3EnterPath;
        private System.Windows.Forms.Panel TopPanel4Menu;
        private System.Windows.Forms.Panel MidPanel4Menu;
    }
}

