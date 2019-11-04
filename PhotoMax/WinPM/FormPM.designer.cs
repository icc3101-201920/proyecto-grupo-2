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
            this.topPanelMainMenu = new System.Windows.Forms.Panel();
            this.TopPanelEditingOptions = new System.Windows.Forms.Panel();
            this.TopPanelApplyFilter = new System.Windows.Forms.Panel();
            this.labelFilterOption = new System.Windows.Forms.Label();
            this.labelEditingOption = new System.Windows.Forms.Label();
            this.TopanelEnterPath = new System.Windows.Forms.Panel();
            this.labelEnterPathsingle = new System.Windows.Forms.Label();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.midPanelPhotomax = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bottonPanelMainMenu = new System.Windows.Forms.Panel();
            this.bottonPanelEnterPath = new System.Windows.Forms.Panel();
            this.bottonPanelPhotoEditing = new System.Windows.Forms.Panel();
            this.bottonPanelFilter = new System.Windows.Forms.Panel();
            this.btnBackFilter = new System.Windows.Forms.Button();
            this.btnBackPhotoEditing = new System.Windows.Forms.Button();
            this.btnBackEnterPath = new System.Windows.Forms.Button();
            this.btnExitMainMenu = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.bottonPanelPhotoMax = new System.Windows.Forms.Panel();
            this.midPanelMainMenu = new System.Windows.Forms.Panel();
            this.midPanelEnterPath = new System.Windows.Forms.Panel();
            this.MidPanelFilterOption = new System.Windows.Forms.Panel();
            this.pictureBoxFilterOption = new System.Windows.Forms.PictureBox();
            this.btnfilterBlossom = new System.Windows.Forms.Button();
            this.btnFilterSepia = new System.Windows.Forms.Button();
            this.btnFilterNegative = new System.Windows.Forms.Button();
            this.btnFilterGreyScale = new System.Windows.Forms.Button();
            this.pictureBoxOpenFile = new System.Windows.Forms.PictureBox();
            this.MidPanelEditingOptions = new System.Windows.Forms.Panel();
            this.btnPhotoEditingRotateImage = new System.Windows.Forms.Button();
            this.btnPhotoEditingInsertText = new System.Windows.Forms.Button();
            this.btnPhotoEditingImageProd = new System.Windows.Forms.Button();
            this.btnPhotoEditingApplyFilter = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMainMenuChoosePath = new System.Windows.Forms.Button();
            this.btnMainMenuUseTEST = new System.Windows.Forms.Button();
            this.btnMainMenuUsingImport = new System.Windows.Forms.Button();
            this.btnMainMenuChooseMultipleImage = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelTEST = new System.Windows.Forms.Panel();
            this.topPanelMainMenu.SuspendLayout();
            this.TopPanelEditingOptions.SuspendLayout();
            this.TopPanelApplyFilter.SuspendLayout();
            this.TopanelEnterPath.SuspendLayout();
            this.midPanelPhotomax.SuspendLayout();
            this.bottonPanelMainMenu.SuspendLayout();
            this.bottonPanelEnterPath.SuspendLayout();
            this.bottonPanelPhotoEditing.SuspendLayout();
            this.bottonPanelFilter.SuspendLayout();
            this.bottonPanelPhotoMax.SuspendLayout();
            this.midPanelMainMenu.SuspendLayout();
            this.midPanelEnterPath.SuspendLayout();
            this.MidPanelFilterOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilterOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).BeginInit();
            this.MidPanelEditingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanelMainMenu
            // 
            this.topPanelMainMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.topPanelMainMenu.Controls.Add(this.TopPanelEditingOptions);
            this.topPanelMainMenu.Controls.Add(this.TopanelEnterPath);
            this.topPanelMainMenu.Controls.Add(this.labelMainMenu);
            this.topPanelMainMenu.Location = new System.Drawing.Point(15, 12);
            this.topPanelMainMenu.Name = "topPanelMainMenu";
            this.topPanelMainMenu.Size = new System.Drawing.Size(773, 39);
            this.topPanelMainMenu.TabIndex = 0;
            this.topPanelMainMenu.Visible = false;
            this.topPanelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanelMainMenu_Paint);
            // 
            // TopPanelEditingOptions
            // 
            this.TopPanelEditingOptions.Controls.Add(this.TopPanelApplyFilter);
            this.TopPanelEditingOptions.Controls.Add(this.labelEditingOption);
            this.TopPanelEditingOptions.Location = new System.Drawing.Point(0, 0);
            this.TopPanelEditingOptions.Name = "TopPanelEditingOptions";
            this.TopPanelEditingOptions.Size = new System.Drawing.Size(773, 38);
            this.TopPanelEditingOptions.TabIndex = 1;
            this.TopPanelEditingOptions.Visible = false;
            // 
            // TopPanelApplyFilter
            // 
            this.TopPanelApplyFilter.Controls.Add(this.labelFilterOption);
            this.TopPanelApplyFilter.Location = new System.Drawing.Point(0, 1);
            this.TopPanelApplyFilter.Name = "TopPanelApplyFilter";
            this.TopPanelApplyFilter.Size = new System.Drawing.Size(773, 37);
            this.TopPanelApplyFilter.TabIndex = 0;
            this.TopPanelApplyFilter.Visible = false;
            // 
            // labelFilterOption
            // 
            this.labelFilterOption.AutoSize = true;
            this.labelFilterOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterOption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFilterOption.Location = new System.Drawing.Point(317, 11);
            this.labelFilterOption.Name = "labelFilterOption";
            this.labelFilterOption.Size = new System.Drawing.Size(144, 24);
            this.labelFilterOption.TabIndex = 0;
            this.labelFilterOption.Text = "Choose a filter";
            this.labelFilterOption.Visible = false;
            // 
            // labelEditingOption
            // 
            this.labelEditingOption.AutoSize = true;
            this.labelEditingOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelEditingOption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEditingOption.Location = new System.Drawing.Point(317, 11);
            this.labelEditingOption.Name = "labelEditingOption";
            this.labelEditingOption.Size = new System.Drawing.Size(175, 24);
            this.labelEditingOption.TabIndex = 1;
            this.labelEditingOption.Text = "Choose an option";
            this.labelEditingOption.Visible = false;
            // 
            // TopanelEnterPath
            // 
            this.TopanelEnterPath.Controls.Add(this.labelEnterPathsingle);
            this.TopanelEnterPath.Location = new System.Drawing.Point(3, 1);
            this.TopanelEnterPath.Name = "TopanelEnterPath";
            this.TopanelEnterPath.Size = new System.Drawing.Size(773, 38);
            this.TopanelEnterPath.TabIndex = 1;
            this.TopanelEnterPath.Visible = false;
            // 
            // labelEnterPathsingle
            // 
            this.labelEnterPathsingle.AutoSize = true;
            this.labelEnterPathsingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelEnterPathsingle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnterPathsingle.Location = new System.Drawing.Point(300, 9);
            this.labelEnterPathsingle.Name = "labelEnterPathsingle";
            this.labelEnterPathsingle.Size = new System.Drawing.Size(174, 24);
            this.labelEnterPathsingle.TabIndex = 0;
            this.labelEnterPathsingle.Text = "Choose an image";
            this.labelEnterPathsingle.Visible = false;
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMainMenu.Location = new System.Drawing.Point(223, 10);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(331, 24);
            this.labelMainMenu.TabIndex = 0;
            this.labelMainMenu.Text = "Select one of the following options";
            this.labelMainMenu.Visible = false;
            // 
            // midPanelPhotomax
            // 
            this.midPanelPhotomax.Controls.Add(this.label1);
            this.midPanelPhotomax.Location = new System.Drawing.Point(15, 57);
            this.midPanelPhotomax.Name = "midPanelPhotomax";
            this.midPanelPhotomax.Size = new System.Drawing.Size(776, 273);
            this.midPanelPhotomax.TabIndex = 1;
            this.midPanelPhotomax.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
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
            // bottonPanelMainMenu
            // 
            this.bottonPanelMainMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bottonPanelMainMenu.Controls.Add(this.bottonPanelEnterPath);
            this.bottonPanelMainMenu.Controls.Add(this.btnExitMainMenu);
            this.bottonPanelMainMenu.Location = new System.Drawing.Point(15, 336);
            this.bottonPanelMainMenu.Name = "bottonPanelMainMenu";
            this.bottonPanelMainMenu.Size = new System.Drawing.Size(776, 32);
            this.bottonPanelMainMenu.TabIndex = 3;
            this.bottonPanelMainMenu.Visible = false;
            // 
            // bottonPanelEnterPath
            // 
            this.bottonPanelEnterPath.Controls.Add(this.bottonPanelPhotoEditing);
            this.bottonPanelEnterPath.Controls.Add(this.btnBackEnterPath);
            this.bottonPanelEnterPath.Location = new System.Drawing.Point(0, 0);
            this.bottonPanelEnterPath.Name = "bottonPanelEnterPath";
            this.bottonPanelEnterPath.Size = new System.Drawing.Size(776, 32);
            this.bottonPanelEnterPath.TabIndex = 5;
            this.bottonPanelEnterPath.Tag = "backbtn";
            this.bottonPanelEnterPath.Visible = false;
            // 
            // bottonPanelPhotoEditing
            // 
            this.bottonPanelPhotoEditing.Controls.Add(this.bottonPanelFilter);
            this.bottonPanelPhotoEditing.Controls.Add(this.btnBackPhotoEditing);
            this.bottonPanelPhotoEditing.Location = new System.Drawing.Point(0, 0);
            this.bottonPanelPhotoEditing.Name = "bottonPanelPhotoEditing";
            this.bottonPanelPhotoEditing.Size = new System.Drawing.Size(776, 32);
            this.bottonPanelPhotoEditing.TabIndex = 4;
            this.bottonPanelPhotoEditing.Visible = false;
            // 
            // bottonPanelFilter
            // 
            this.bottonPanelFilter.Controls.Add(this.btnBackFilter);
            this.bottonPanelFilter.Location = new System.Drawing.Point(0, 0);
            this.bottonPanelFilter.Name = "bottonPanelFilter";
            this.bottonPanelFilter.Size = new System.Drawing.Size(776, 32);
            this.bottonPanelFilter.TabIndex = 1;
            this.bottonPanelFilter.Visible = false;
            // 
            // btnBackFilter
            // 
            this.btnBackFilter.Location = new System.Drawing.Point(357, 6);
            this.btnBackFilter.Name = "btnBackFilter";
            this.btnBackFilter.Size = new System.Drawing.Size(75, 23);
            this.btnBackFilter.TabIndex = 0;
            this.btnBackFilter.Text = "back";
            this.btnBackFilter.UseVisualStyleBackColor = true;
            this.btnBackFilter.Visible = false;
            this.btnBackFilter.Click += new System.EventHandler(this.btnBackFilter_Click);
            // 
            // btnBackPhotoEditing
            // 
            this.btnBackPhotoEditing.Location = new System.Drawing.Point(348, 6);
            this.btnBackPhotoEditing.Name = "btnBackPhotoEditing";
            this.btnBackPhotoEditing.Size = new System.Drawing.Size(75, 23);
            this.btnBackPhotoEditing.TabIndex = 0;
            this.btnBackPhotoEditing.Text = "back";
            this.btnBackPhotoEditing.UseVisualStyleBackColor = true;
            this.btnBackPhotoEditing.Visible = false;
            this.btnBackPhotoEditing.Click += new System.EventHandler(this.btnBackPhotoEditing_Click);
            // 
            // btnBackEnterPath
            // 
            this.btnBackEnterPath.Location = new System.Drawing.Point(348, 3);
            this.btnBackEnterPath.Name = "btnBackEnterPath";
            this.btnBackEnterPath.Size = new System.Drawing.Size(75, 23);
            this.btnBackEnterPath.TabIndex = 0;
            this.btnBackEnterPath.Text = "Back";
            this.btnBackEnterPath.UseVisualStyleBackColor = true;
            this.btnBackEnterPath.Visible = false;
            this.btnBackEnterPath.Click += new System.EventHandler(this.btnBackEnterPath_Click);
            // 
            // btnExitMainMenu
            // 
            this.btnExitMainMenu.Location = new System.Drawing.Point(357, 3);
            this.btnExitMainMenu.Name = "btnExitMainMenu";
            this.btnExitMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnExitMainMenu.TabIndex = 4;
            this.btnExitMainMenu.Text = "Exit";
            this.btnExitMainMenu.UseVisualStyleBackColor = true;
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
            // bottonPanelPhotoMax
            // 
            this.bottonPanelPhotoMax.Controls.Add(this.btnStart);
            this.bottonPanelPhotoMax.Location = new System.Drawing.Point(15, 340);
            this.bottonPanelPhotoMax.Name = "bottonPanelPhotoMax";
            this.bottonPanelPhotoMax.Size = new System.Drawing.Size(773, 28);
            this.bottonPanelPhotoMax.TabIndex = 2;
            this.bottonPanelPhotoMax.Tag = "start";
            // 
            // midPanelMainMenu
            // 
            this.midPanelMainMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.midPanelMainMenu.Controls.Add(this.midPanelEnterPath);
            this.midPanelMainMenu.Controls.Add(this.btnMainMenuChoosePath);
            this.midPanelMainMenu.Controls.Add(this.btnMainMenuUseTEST);
            this.midPanelMainMenu.Controls.Add(this.btnMainMenuUsingImport);
            this.midPanelMainMenu.Controls.Add(this.btnMainMenuChooseMultipleImage);
            this.midPanelMainMenu.Location = new System.Drawing.Point(15, 58);
            this.midPanelMainMenu.Name = "midPanelMainMenu";
            this.midPanelMainMenu.Size = new System.Drawing.Size(773, 272);
            this.midPanelMainMenu.TabIndex = 1;
            this.midPanelMainMenu.Visible = false;
            this.midPanelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // midPanelEnterPath
            // 
            this.midPanelEnterPath.Controls.Add(this.MidPanelFilterOption);
            this.midPanelEnterPath.Controls.Add(this.pictureBoxOpenFile);
            this.midPanelEnterPath.Controls.Add(this.MidPanelEditingOptions);
            this.midPanelEnterPath.Controls.Add(this.btnNext);
            this.midPanelEnterPath.Location = new System.Drawing.Point(3, 3);
            this.midPanelEnterPath.Name = "midPanelEnterPath";
            this.midPanelEnterPath.Size = new System.Drawing.Size(773, 266);
            this.midPanelEnterPath.TabIndex = 5;
            this.midPanelEnterPath.Visible = false;
            this.midPanelEnterPath.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // MidPanelFilterOption
            // 
            this.MidPanelFilterOption.Controls.Add(this.pictureBoxFilterOption);
            this.MidPanelFilterOption.Controls.Add(this.btnfilterBlossom);
            this.MidPanelFilterOption.Controls.Add(this.btnFilterSepia);
            this.MidPanelFilterOption.Controls.Add(this.btnFilterNegative);
            this.MidPanelFilterOption.Controls.Add(this.btnFilterGreyScale);
            this.MidPanelFilterOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidPanelFilterOption.Location = new System.Drawing.Point(0, 0);
            this.MidPanelFilterOption.Name = "MidPanelFilterOption";
            this.MidPanelFilterOption.Size = new System.Drawing.Size(773, 266);
            this.MidPanelFilterOption.TabIndex = 4;
            this.MidPanelFilterOption.Visible = false;
            this.MidPanelFilterOption.Paint += new System.Windows.Forms.PaintEventHandler(this.MidPanelFilterOption_Paint);
            // 
            // pictureBoxFilterOption
            // 
            this.pictureBoxFilterOption.Location = new System.Drawing.Point(414, 45);
            this.pictureBoxFilterOption.Name = "pictureBoxFilterOption";
            this.pictureBoxFilterOption.Size = new System.Drawing.Size(294, 150);
            this.pictureBoxFilterOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFilterOption.TabIndex = 4;
            this.pictureBoxFilterOption.TabStop = false;
            // 
            // btnfilterBlossom
            // 
            this.btnfilterBlossom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilterBlossom.Location = new System.Drawing.Point(72, 162);
            this.btnfilterBlossom.Name = "btnfilterBlossom";
            this.btnfilterBlossom.Size = new System.Drawing.Size(173, 33);
            this.btnfilterBlossom.TabIndex = 3;
            this.btnfilterBlossom.Text = "Blossom";
            this.btnfilterBlossom.UseVisualStyleBackColor = true;
            this.btnfilterBlossom.Visible = false;
            this.btnfilterBlossom.Click += new System.EventHandler(this.btnfilterBlossom_Click);
            this.btnfilterBlossom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnfilterBlossom_MouseMove);
            // 
            // btnFilterSepia
            // 
            this.btnFilterSepia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterSepia.Location = new System.Drawing.Point(72, 123);
            this.btnFilterSepia.Name = "btnFilterSepia";
            this.btnFilterSepia.Size = new System.Drawing.Size(173, 33);
            this.btnFilterSepia.TabIndex = 2;
            this.btnFilterSepia.Text = "Sepia";
            this.btnFilterSepia.UseVisualStyleBackColor = true;
            this.btnFilterSepia.Visible = false;
            this.btnFilterSepia.Click += new System.EventHandler(this.btnFilterSepia_Click);
            this.btnFilterSepia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFilterSepia_MouseMove);
            // 
            // btnFilterNegative
            // 
            this.btnFilterNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterNegative.Location = new System.Drawing.Point(72, 84);
            this.btnFilterNegative.Name = "btnFilterNegative";
            this.btnFilterNegative.Size = new System.Drawing.Size(173, 33);
            this.btnFilterNegative.TabIndex = 1;
            this.btnFilterNegative.TabStop = false;
            this.btnFilterNegative.Text = "Negative";
            this.btnFilterNegative.UseVisualStyleBackColor = true;
            this.btnFilterNegative.Visible = false;
            this.btnFilterNegative.Click += new System.EventHandler(this.btnFilterNegative_Click);
            this.btnFilterNegative.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFilterNegative_MouseMove);
            // 
            // btnFilterGreyScale
            // 
            this.btnFilterGreyScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterGreyScale.Location = new System.Drawing.Point(72, 45);
            this.btnFilterGreyScale.Name = "btnFilterGreyScale";
            this.btnFilterGreyScale.Size = new System.Drawing.Size(173, 33);
            this.btnFilterGreyScale.TabIndex = 0;
            this.btnFilterGreyScale.Text = "GreyScale";
            this.btnFilterGreyScale.UseVisualStyleBackColor = true;
            this.btnFilterGreyScale.Visible = false;
            this.btnFilterGreyScale.Click += new System.EventHandler(this.btnFilterGreyScale_Click);
            this.btnFilterGreyScale.MouseEnter += new System.EventHandler(this.btnFilterGreyScale_MouseEnter);
            // 
            // pictureBoxOpenFile
            // 
            this.pictureBoxOpenFile.Location = new System.Drawing.Point(48, 71);
            this.pictureBoxOpenFile.Name = "pictureBoxOpenFile";
            this.pictureBoxOpenFile.Size = new System.Drawing.Size(660, 158);
            this.pictureBoxOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpenFile.TabIndex = 3;
            this.pictureBoxOpenFile.TabStop = false;
            // 
            // MidPanelEditingOptions
            // 
            this.MidPanelEditingOptions.Controls.Add(this.btnPhotoEditingRotateImage);
            this.MidPanelEditingOptions.Controls.Add(this.btnPhotoEditingInsertText);
            this.MidPanelEditingOptions.Controls.Add(this.btnPhotoEditingImageProd);
            this.MidPanelEditingOptions.Controls.Add(this.btnPhotoEditingApplyFilter);
            this.MidPanelEditingOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidPanelEditingOptions.Location = new System.Drawing.Point(0, 0);
            this.MidPanelEditingOptions.Name = "MidPanelEditingOptions";
            this.MidPanelEditingOptions.Size = new System.Drawing.Size(773, 266);
            this.MidPanelEditingOptions.TabIndex = 2;
            this.MidPanelEditingOptions.Visible = false;
            // 
            // btnPhotoEditingRotateImage
            // 
            this.btnPhotoEditingRotateImage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoEditingRotateImage.Location = new System.Drawing.Point(6, 189);
            this.btnPhotoEditingRotateImage.Name = "btnPhotoEditingRotateImage";
            this.btnPhotoEditingRotateImage.Size = new System.Drawing.Size(399, 40);
            this.btnPhotoEditingRotateImage.TabIndex = 3;
            this.btnPhotoEditingRotateImage.Text = "Rotate Image";
            this.btnPhotoEditingRotateImage.UseVisualStyleBackColor = true;
            this.btnPhotoEditingRotateImage.Visible = false;
            // 
            // btnPhotoEditingInsertText
            // 
            this.btnPhotoEditingInsertText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoEditingInsertText.Location = new System.Drawing.Point(3, 128);
            this.btnPhotoEditingInsertText.Name = "btnPhotoEditingInsertText";
            this.btnPhotoEditingInsertText.Size = new System.Drawing.Size(399, 40);
            this.btnPhotoEditingInsertText.TabIndex = 2;
            this.btnPhotoEditingInsertText.Text = "Insert Text";
            this.btnPhotoEditingInsertText.UseVisualStyleBackColor = true;
            this.btnPhotoEditingInsertText.Visible = false;
            // 
            // btnPhotoEditingImageProd
            // 
            this.btnPhotoEditingImageProd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoEditingImageProd.Location = new System.Drawing.Point(6, 66);
            this.btnPhotoEditingImageProd.Name = "btnPhotoEditingImageProd";
            this.btnPhotoEditingImageProd.Size = new System.Drawing.Size(399, 40);
            this.btnPhotoEditingImageProd.TabIndex = 1;
            this.btnPhotoEditingImageProd.Text = "Image Production";
            this.btnPhotoEditingImageProd.UseVisualStyleBackColor = true;
            this.btnPhotoEditingImageProd.Visible = false;
            this.btnPhotoEditingImageProd.Click += new System.EventHandler(this.btnPhotoEditingImageProd_Click);
            // 
            // btnPhotoEditingApplyFilter
            // 
            this.btnPhotoEditingApplyFilter.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoEditingApplyFilter.Location = new System.Drawing.Point(6, 3);
            this.btnPhotoEditingApplyFilter.Name = "btnPhotoEditingApplyFilter";
            this.btnPhotoEditingApplyFilter.Size = new System.Drawing.Size(399, 40);
            this.btnPhotoEditingApplyFilter.TabIndex = 0;
            this.btnPhotoEditingApplyFilter.Text = "Apply Filter";
            this.btnPhotoEditingApplyFilter.UseVisualStyleBackColor = true;
            this.btnPhotoEditingApplyFilter.Visible = false;
            this.btnPhotoEditingApplyFilter.Click += new System.EventHandler(this.btn4Filter_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(673, 32);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMainMenuChoosePath
            // 
            this.btnMainMenuChoosePath.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuChoosePath.Location = new System.Drawing.Point(69, 18);
            this.btnMainMenuChoosePath.Name = "btnMainMenuChoosePath";
            this.btnMainMenuChoosePath.Size = new System.Drawing.Size(648, 50);
            this.btnMainMenuChoosePath.TabIndex = 4;
            this.btnMainMenuChoosePath.Text = "Select a file";
            this.btnMainMenuChoosePath.UseVisualStyleBackColor = true;
            this.btnMainMenuChoosePath.Click += new System.EventHandler(this.btn2Option1_Click);
            // 
            // btnMainMenuUseTEST
            // 
            this.btnMainMenuUseTEST.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuUseTEST.Location = new System.Drawing.Point(69, 186);
            this.btnMainMenuUseTEST.Name = "btnMainMenuUseTEST";
            this.btnMainMenuUseTEST.Size = new System.Drawing.Size(648, 50);
            this.btnMainMenuUseTEST.TabIndex = 3;
            this.btnMainMenuUseTEST.Text = "TEST with an image";
            this.btnMainMenuUseTEST.UseVisualStyleBackColor = true;
            // 
            // btnMainMenuUsingImport
            // 
            this.btnMainMenuUsingImport.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuUsingImport.Location = new System.Drawing.Point(69, 130);
            this.btnMainMenuUsingImport.Name = "btnMainMenuUsingImport";
            this.btnMainMenuUsingImport.Size = new System.Drawing.Size(648, 50);
            this.btnMainMenuUsingImport.TabIndex = 2;
            this.btnMainMenuUsingImport.Text = "Select image to work with import folder";
            this.btnMainMenuUsingImport.UseVisualStyleBackColor = true;
            this.btnMainMenuUsingImport.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMainMenuChooseMultipleImage
            // 
            this.btnMainMenuChooseMultipleImage.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuChooseMultipleImage.Location = new System.Drawing.Point(69, 74);
            this.btnMainMenuChooseMultipleImage.Name = "btnMainMenuChooseMultipleImage";
            this.btnMainMenuChooseMultipleImage.Size = new System.Drawing.Size(648, 50);
            this.btnMainMenuChooseMultipleImage.TabIndex = 1;
            this.btnMainMenuChooseMultipleImage.Text = "Import multiple files by directory location";
            this.btnMainMenuChooseMultipleImage.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "SaveDialogFilter";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelTEST
            // 
            this.panelTEST.Location = new System.Drawing.Point(15, 56);
            this.panelTEST.Name = "panelTEST";
            this.panelTEST.Size = new System.Drawing.Size(525, 159);
            this.panelTEST.TabIndex = 5;
            this.panelTEST.Visible = false;
            // 
            // FormPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.panelTEST);
            this.Controls.Add(this.midPanelMainMenu);
            this.Controls.Add(this.bottonPanelMainMenu);
            this.Controls.Add(this.bottonPanelPhotoMax);
            this.Controls.Add(this.midPanelPhotomax);
            this.Controls.Add(this.topPanelMainMenu);
            this.Name = "FormPM";
            this.Text = "PhotoMax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanelMainMenu.ResumeLayout(false);
            this.topPanelMainMenu.PerformLayout();
            this.TopPanelEditingOptions.ResumeLayout(false);
            this.TopPanelEditingOptions.PerformLayout();
            this.TopPanelApplyFilter.ResumeLayout(false);
            this.TopPanelApplyFilter.PerformLayout();
            this.TopanelEnterPath.ResumeLayout(false);
            this.TopanelEnterPath.PerformLayout();
            this.midPanelPhotomax.ResumeLayout(false);
            this.midPanelPhotomax.PerformLayout();
            this.bottonPanelMainMenu.ResumeLayout(false);
            this.bottonPanelEnterPath.ResumeLayout(false);
            this.bottonPanelPhotoEditing.ResumeLayout(false);
            this.bottonPanelFilter.ResumeLayout(false);
            this.bottonPanelPhotoMax.ResumeLayout(false);
            this.midPanelMainMenu.ResumeLayout(false);
            this.midPanelEnterPath.ResumeLayout(false);
            this.MidPanelFilterOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilterOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).EndInit();
            this.MidPanelEditingOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanelMainMenu;
        private System.Windows.Forms.Panel midPanelPhotomax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bottonPanelMainMenu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel bottonPanelPhotoMax;
        private System.Windows.Forms.Button btnExitMainMenu;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Panel TopanelEnterPath;
        private System.Windows.Forms.Label labelEnterPathsingle;
        private System.Windows.Forms.Panel midPanelMainMenu;
        private System.Windows.Forms.Button btnMainMenuChoosePath;
        private System.Windows.Forms.Button btnMainMenuUseTEST;
        private System.Windows.Forms.Button btnMainMenuUsingImport;
        private System.Windows.Forms.Button btnMainMenuChooseMultipleImage;
        private System.Windows.Forms.Panel midPanelEnterPath;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel TopPanelEditingOptions;
        private System.Windows.Forms.Panel MidPanelEditingOptions;
        private System.Windows.Forms.Button btnPhotoEditingApplyFilter;
        private System.Windows.Forms.Button btnPhotoEditingRotateImage;
        private System.Windows.Forms.Button btnPhotoEditingInsertText;
        private System.Windows.Forms.Button btnPhotoEditingImageProd;
        private System.Windows.Forms.Panel TopPanelApplyFilter;
        private System.Windows.Forms.Label labelFilterOption;
        private System.Windows.Forms.Panel MidPanelFilterOption;
        private System.Windows.Forms.Button btnfilterBlossom;
        private System.Windows.Forms.Button btnFilterSepia;
        private System.Windows.Forms.Button btnFilterNegative;
        private System.Windows.Forms.Button btnFilterGreyScale;
        private System.Windows.Forms.Panel bottonPanelEnterPath;
        private System.Windows.Forms.Panel bottonPanelPhotoEditing;
        private System.Windows.Forms.Button btnBackPhotoEditing;
        private System.Windows.Forms.Button btnBackEnterPath;
        private System.Windows.Forms.Label labelEditingOption;
        private System.Windows.Forms.PictureBox pictureBoxFilterOption;
        private System.Windows.Forms.Panel bottonPanelFilter;
        private System.Windows.Forms.Button btnBackFilter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxOpenFile;
        private System.Windows.Forms.Panel panelTEST;
    }
}

