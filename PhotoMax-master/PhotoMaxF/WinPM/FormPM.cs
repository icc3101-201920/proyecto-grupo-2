using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinPM
{
    public partial class FormPM : Form
    {
        // Para ir haciendo el forms del programa:

        //1)La gracia es que solo debe haber 1 forms y mientras se van haciendo clicks en botones ir "navegando" en los
        //paneles

        //2)Los nombres de los diferente eventos del toolbar tienen numero, ese numero es perteneciente al numero del paner en el
        //que están puesto

        //EJ: En mi panel 1 tendré botones/barras/label/ lo que sea, estos tienen el nombre respectivo de la herramienta

        //    el NUMERO al panel al que pertenecen y la accion correspondiente

        //3)Cuando hago click en un boton para proceder a una accion siguiente tal como "aplicar filtro" --> "sepia" --> "guardar"
        //es cuando se cambian los panel

        //EJ: en el caso anterior pasaríamos del panel 6 --> 7 --> 8. 

        PhotoMaxF.Importer importer = new PhotoMaxF.Importer();
        PhotoMaxF.SaveData SaveData = new PhotoMaxF.SaveData();
        PhotoMaxF.Launcher launcher = new PhotoMaxF.Launcher();

        public event EventHandler OnApplyFilter;
        public event EventHandler OnApplyText;
        public event EventHandler OnRotateImage;
        public event EventHandler OnImageProduction;
        public event EventHandler OnSaveImage;

        //Hay que hacer eventos que hagan lo siguiente
        // --> cuando se apriete cierto boton : haga una aplicacion de filtros
        // --> cuando se apriete cierto boton : pueda ingresar texto
        // --> cuando apriete cierto boton me muestre todas las propiedades de una foto
        // --> cuando apriete cierto boton, guarde la foto en una carpeta
        // --> cuando escriba el path y aprete "enter" logre reconocer que hay una foto ahi y ese archivo se tiene que usar
        // --> 
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
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn2Enterpath_Click(object sender, EventArgs e)
        {

        }

        private void btn2Option1_Click(object sender, EventArgs e)
        {
            midPanel3Option1.Visible = true;
            Topanel3Op1.Visible = true;
            label3Option1.Visible = true;
            textBox3EnterPath.Visible = true;
            btn3EnterPath.Visible = true;

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn3EnterPath_Click(object sender, EventArgs e)
        {
            string Path;
            
            Path = textBox3EnterPath.Text;
            MidPanel4Menu.Visible = true;
            btn4Filter.Visible = true;
            btn4ImageProd.Visible = true;
            btn4InsertText.Visible = true;
            btn4RotateImage.Visible = true;
            btn3EnterPath.Visible = false;
            
            

            
        }

        private void textBox3EnterPath_TextChanged(object sender, EventArgs e)
        {
            string Path;
            Path = textBox3EnterPath.Text;

             
        }

        private void btn4Filter_Click(object sender, EventArgs e)
        {
            MidPanel5Filter.Visible = true;
            btn5FilterGrayscale.Visible = true;
            btn5FilterAqua.Visible = true;
            btn5filterRed.Visible = true;
            btn5FilterSepia.Visible = true;
            // trun off panels
            btn4InsertText.Visible = false;
            btn4ImageProd.Visible = false;
            btn4RotateImage.Visible = false;
        }
    }
}
