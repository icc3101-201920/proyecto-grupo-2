using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotomaxForm
{
    public partial class FormPM : Form
    {
        public FormPM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BntStart_Click(object sender, EventArgs e)
        {
            Button btnStart = new Button();
            // Esto hace que vaya pasando de panel el panel, se oculan unos y aparecen otros cuando
            // hago click
            midPanel2.Visible = true;
            midPanel.Visible = false;
            bottonPanel1.Visible = false;
            bottonPanel2.Visible = true;
            topPanel2.Visible = true;
            
            

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox2option3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
