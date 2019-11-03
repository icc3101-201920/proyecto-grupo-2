﻿using System;
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
            midPanelMainMenu.Visible = true;
            bottonPanelMainMenu.Visible = true;
            topPanelMainMenu.Visible = true;
            btnMainMenuChooseMultipleImage.Visible = true;
            btnMainMenuChoosePath.Visible = true;
            btnMainMenuUseTEST.Visible = true;
            btnMainMenuUsingImport.Visible = true;
            labelMainMenu.Visible = true;
            btnExitMainMenu.Visible = true;

            midPanelPhotomax.Visible = false;
            bottonPanelPhotoMax.Visible = false;
            label1.Visible = false;



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
            midPanelEnterPath.Visible = true;
            TopanelEnterPath.Visible = true;
            bottonPanelEnterPath.Visible = true;
            labelEnterPathsingle.Visible = true;
            textBoxEnterPath.Visible = true;
            btnEnterPath.Visible = true;
            btnBackEnterPath.Visible = true;







        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn3EnterPath_Click(object sender, EventArgs e)
        {
            string Path;
            
            Path = textBoxEnterPath.Text;
            MidPanelEditingOptions.Visible = true;
            btnPhotoEditingApplyFilter.Visible = true;
            btnPhotoEditingImageProd.Visible = true;
            btnPhotoEditingInsertText.Visible = true;
            btnPhotoEditingRotateImage.Visible = true;
            bottonPanelPhotoEditing.Visible = true;
            TopPanelEditingOptions.Visible = true;
            btnBackPhotoEditing.Visible = true;
            labelEditingOption.Visible = true;
            btnBackPhotoEditing.Visible = true;

            btnEnterPath.Visible = false;
            labelEnterPathsingle.Visible = false;



            
            

            
        }

        private void textBox3EnterPath_TextChanged(object sender, EventArgs e)
        {
            string Path;
            Path = textBoxEnterPath.Text;

             
        }

        private void btn4Filter_Click(object sender, EventArgs e)
        {
            TopPanelApplyFilter.Visible = true;
            MidPanelFilterOption.Visible = true;
            btnFilterNegative.Visible = true;
            btnFilterSepia.Visible = true;
            btnfilterBlossom.Visible = true;
            btnFilterGreyScale.Visible = true;
            labelFilterOption.Visible = true;
            bottonPanelFilter.Visible = true;
            btnBackFilter.Visible = true;
            
            
            pictureBoxFilterOption.Visible = true;
            // trun off panels
            btnPhotoEditingInsertText.Visible = false;
            btnPhotoEditingImageProd.Visible = false;
            btnPhotoEditingRotateImage.Visible = false;
            TopPanelEditingOptions.Visible = false;
            TopanelEnterPath.Visible = false;
            
        }

        private void btnBackEnterPath_Click(object sender, EventArgs e)
        {
            midPanelMainMenu.Visible = true;
            topPanelMainMenu.Visible = true;
            bottonPanelMainMenu.Visible = true;
            btnMainMenuChooseMultipleImage.Visible = true;
            btnMainMenuChoosePath.Visible = true;
            btnMainMenuUseTEST.Visible = true;
            btnMainMenuUsingImport.Visible = true;

            midPanelEnterPath.Visible = false;
            TopanelEnterPath.Visible = false;
            bottonPanelEnterPath.Visible = false;
            textBoxEnterPath.Visible = false;
            btnBackEnterPath.Visible = false;

        }

        private void btnBackPhotoEditing_Click(object sender, EventArgs e)
        {
            midPanelEnterPath.Visible = true;
            TopanelEnterPath.Visible = true;
            bottonPanelEnterPath.Visible = true;
            textBoxEnterPath.Visible = true;
            btnBackEnterPath.Visible = true;
            labelEnterPathsingle.Visible = true;
            btnEnterPath.Visible = true;

            MidPanelEditingOptions.Visible = false;
            btnPhotoEditingApplyFilter.Visible = false;
            btnPhotoEditingImageProd.Visible = false;
            btnPhotoEditingInsertText.Visible = false;
            btnPhotoEditingRotateImage.Visible = false;
            bottonPanelPhotoEditing.Visible = false;
            TopPanelEditingOptions.Visible = false;
            btnBackPhotoEditing.Visible = false;
            labelEditingOption.Visible = false;
            btnBackPhotoEditing.Visible = false;

        }

        private void btnBackFilter_Click(object sender, EventArgs e)
        {
            TopPanelApplyFilter.Visible = false;
            MidPanelFilterOption.Visible = false;
            bottonPanelFilter.Visible = false;
            btnfilterBlossom.Visible = false;
            btnFilterGreyScale.Visible = false;
            btnFilterSepia.Visible = false;
            btnFilterNegative.Visible = false;
            labelFilterOption.Visible = false;
            btnBackFilter.Visible = false;

            MidPanelEditingOptions.Visible = true;
            bottonPanelPhotoEditing.Visible = true;
            TopPanelEditingOptions.Visible = true;
            btnPhotoEditingApplyFilter.Visible = true;
            btnPhotoEditingImageProd.Visible = true;
            btnPhotoEditingInsertText.Visible = true;
            btnPhotoEditingRotateImage.Visible = true;
            btnBackPhotoEditing.Visible = true;
            labelEditingOption.Visible = true;
            btnBackPhotoEditing.Visible = true;
            

        }

        private void topPanelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilterGreyScale_Click(object sender, EventArgs e)
        {
            MidMiniPanelAgree.Visible = true;
            btnMiniApplyNO.Visible = true;
            btnMiniApplyYES.Visible = true;
            labelApplyChosenFilter.Visible = true;
        }

        private void btnMiniApplyNO_Click(object sender, EventArgs e)
        {
            MidMiniPanelAgree.Visible = false;
            btnMiniApplyYES.Visible = false;
            btnMiniApplyYES.Visible = false;
            labelApplyChosenFilter.Visible = false;
        }

        private void textBoxSavePath1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMiniApplyYES_Click(object sender, EventArgs e)
        {
            labelHintPath.Visible = true;
            textBoxSavePath1.Visible = true;
            labelEnterSavePathName.Visible = true;
        }
    }
}
