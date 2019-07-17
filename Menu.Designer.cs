namespace Gestion_Academica
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.draging = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabEstudiante = new System.Windows.Forms.TabControl();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.picIconBusqueda = new System.Windows.Forms.PictureBox();
            this.txtBusquedaEstudiante = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.N_Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.bunifuCustomTextbox4 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox3 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEstudiante = new System.Windows.Forms.Panel();
            this.pnlProfesores = new System.Windows.Forms.Panel();
            this.pnlCarreras = new System.Windows.Forms.Panel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarreras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnprofesor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEstudiante = new Bunifu.Framework.UI.BunifuFlatButton();
            this.draging.SuspendLayout();
            this.tabEstudiante.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // draging
            // 
            this.draging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.draging.Controls.Add(this.btnClose);
            this.draging.Location = new System.Drawing.Point(0, 0);
            this.draging.Margin = new System.Windows.Forms.Padding(4);
            this.draging.Name = "draging";
            this.draging.Size = new System.Drawing.Size(1200, 32);
            this.draging.TabIndex = 14;
            this.draging.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.draging.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.draging.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(132)))), ((int)(((byte)(205)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(132)))), ((int)(((byte)(205)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnClose.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnClose.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1149, -11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 54);
            this.btnClose.TabIndex = 100;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabEstudiante
            // 
            this.tabEstudiante.Controls.Add(this.tabBusqueda);
            this.tabEstudiante.Controls.Add(this.tabInfo);
            this.tabEstudiante.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.tabEstudiante.ItemSize = new System.Drawing.Size(100, 30);
            this.tabEstudiante.Location = new System.Drawing.Point(200, 32);
            this.tabEstudiante.Name = "tabEstudiante";
            this.tabEstudiante.Padding = new System.Drawing.Point(9, 3);
            this.tabEstudiante.SelectedIndex = 0;
            this.tabEstudiante.Size = new System.Drawing.Size(1000, 671);
            this.tabEstudiante.TabIndex = 19;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.BackColor = System.Drawing.Color.White;
            this.tabBusqueda.Controls.Add(this.picIconBusqueda);
            this.tabBusqueda.Controls.Add(this.txtBusquedaEstudiante);
            this.tabBusqueda.Controls.Add(this.bunifuCustomDataGrid1);
            this.tabBusqueda.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBusqueda.Location = new System.Drawing.Point(4, 34);
            this.tabBusqueda.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(992, 633);
            this.tabBusqueda.TabIndex = 0;
            this.tabBusqueda.Text = "Busqueda";
            // 
            // picIconBusqueda
            // 
            this.picIconBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.picIconBusqueda.Image = global::Gestion_Academica.Properties.Resources.magnifier_gray;
            this.picIconBusqueda.Location = new System.Drawing.Point(617, 103);
            this.picIconBusqueda.Name = "picIconBusqueda";
            this.picIconBusqueda.Size = new System.Drawing.Size(26, 24);
            this.picIconBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIconBusqueda.TabIndex = 1;
            this.picIconBusqueda.TabStop = false;
            // 
            // txtBusquedaEstudiante
            // 
            this.txtBusquedaEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtBusquedaEstudiante.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtBusquedaEstudiante.HintText = "Nombre o Nº Carnet";
            this.txtBusquedaEstudiante.isPassword = false;
            this.txtBusquedaEstudiante.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtBusquedaEstudiante.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtBusquedaEstudiante.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtBusquedaEstudiante.LineThickness = 3;
            this.txtBusquedaEstudiante.Location = new System.Drawing.Point(307, 102);
            this.txtBusquedaEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaEstudiante.Name = "txtBusquedaEstudiante";
            this.txtBusquedaEstudiante.Size = new System.Drawing.Size(341, 33);
            this.txtBusquedaEstudiante.TabIndex = 3;
            this.txtBusquedaEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusquedaEstudiante.OnValueChanged += new System.EventHandler(this.txtBusquedaEstudiante_OnValueChanged);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Carnet,
            this.Nombre,
            this.Carrera,
            this.Turno});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(87, 178);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 25;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(831, 349);
            this.bunifuCustomDataGrid1.TabIndex = 2;
            // 
            // N_Carnet
            // 
            this.N_Carnet.HeaderText = "N_Carnet";
            this.N_Carnet.Name = "N_Carnet";
            this.N_Carnet.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 320;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 200;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Width = 120;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.White;
            this.tabInfo.Controls.Add(this.bunifuCustomTextbox4);
            this.tabInfo.Controls.Add(this.bunifuCustomLabel4);
            this.tabInfo.Controls.Add(this.bunifuCustomTextbox2);
            this.tabInfo.Controls.Add(this.bunifuCustomLabel2);
            this.tabInfo.Controls.Add(this.bunifuCustomTextbox1);
            this.tabInfo.Controls.Add(this.bunifuCustomLabel1);
            this.tabInfo.Controls.Add(this.bunifuCustomTextbox3);
            this.tabInfo.Controls.Add(this.bunifuCustomLabel3);
            this.tabInfo.Location = new System.Drawing.Point(4, 34);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(992, 633);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Informacion";
            // 
            // bunifuCustomTextbox4
            // 
            this.bunifuCustomTextbox4.BorderColor = System.Drawing.Color.LawnGreen;
            this.bunifuCustomTextbox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.bunifuCustomTextbox4.Location = new System.Drawing.Point(750, 112);
            this.bunifuCustomTextbox4.Multiline = true;
            this.bunifuCustomTextbox4.Name = "bunifuCustomTextbox4";
            this.bunifuCustomTextbox4.Size = new System.Drawing.Size(195, 27);
            this.bunifuCustomTextbox4.TabIndex = 11;
            this.bunifuCustomTextbox4.Text = "4812609970000D";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(647, 109);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 28);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "N_Cedula:";
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.LawnGreen;
            this.bunifuCustomTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(446, 111);
            this.bunifuCustomTextbox2.Multiline = true;
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(195, 27);
            this.bunifuCustomTextbox2.TabIndex = 7;
            this.bunifuCustomTextbox2.Text = "Obregon Vasquez";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(349, 108);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(128, 28);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Apellidos:";
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.LawnGreen;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(148, 110);
            this.bunifuCustomTextbox1.Multiline = true;
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(195, 27);
            this.bunifuCustomTextbox1.TabIndex = 5;
            this.bunifuCustomTextbox1.Text = "Franklin Alberto";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 107);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(125, 28);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Nombres:";
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.LawnGreen;
            this.bunifuCustomTextbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.bunifuCustomTextbox3.Location = new System.Drawing.Point(150, 63);
            this.bunifuCustomTextbox3.Multiline = true;
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.Size = new System.Drawing.Size(167, 27);
            this.bunifuCustomTextbox3.TabIndex = 9;
            this.bunifuCustomTextbox3.Text = "20154500094";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(54, 61);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(128, 28);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "N_Carnet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "SGA";
            // 
            // pnlEstudiante
            // 
            this.pnlEstudiante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEstudiante.Location = new System.Drawing.Point(0, 223);
            this.pnlEstudiante.Name = "pnlEstudiante";
            this.pnlEstudiante.Size = new System.Drawing.Size(6, 40);
            this.pnlEstudiante.TabIndex = 19;
            // 
            // pnlProfesores
            // 
            this.pnlProfesores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlProfesores.Location = new System.Drawing.Point(0, 299);
            this.pnlProfesores.Name = "pnlProfesores";
            this.pnlProfesores.Size = new System.Drawing.Size(6, 40);
            this.pnlProfesores.TabIndex = 20;
            // 
            // pnlCarreras
            // 
            this.pnlCarreras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCarreras.Location = new System.Drawing.Point(0, 375);
            this.pnlCarreras.Name = "pnlCarreras";
            this.pnlCarreras.Size = new System.Drawing.Size(6, 40);
            this.pnlCarreras.TabIndex = 24;
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.panel0.Controls.Add(this.pnlCarreras);
            this.panel0.Controls.Add(this.pnlProfesores);
            this.panel0.Controls.Add(this.pnlEstudiante);
            this.panel0.Controls.Add(this.label1);
            this.panel0.Controls.Add(this.pictureBox1);
            this.panel0.Controls.Add(this.btnCarreras);
            this.panel0.Controls.Add(this.btnprofesor);
            this.panel0.Controls.Add(this.btnEstudiante);
            this.panel0.Location = new System.Drawing.Point(0, 32);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(200, 668);
            this.panel0.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarreras
            // 
            this.btnCarreras.Activecolor = System.Drawing.Color.Transparent;
            this.btnCarreras.BackColor = System.Drawing.Color.Transparent;
            this.btnCarreras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarreras.BorderRadius = 0;
            this.btnCarreras.ButtonText = "  Carreras";
            this.btnCarreras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarreras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCarreras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCarreras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCarreras.Iconimage")));
            this.btnCarreras.Iconimage_right = null;
            this.btnCarreras.Iconimage_right_Selected = null;
            this.btnCarreras.Iconimage_Selected = null;
            this.btnCarreras.IconMarginLeft = 0;
            this.btnCarreras.IconMarginRight = 0;
            this.btnCarreras.IconRightVisible = true;
            this.btnCarreras.IconRightZoom = 0D;
            this.btnCarreras.IconVisible = true;
            this.btnCarreras.IconZoom = 75D;
            this.btnCarreras.IsTab = false;
            this.btnCarreras.Location = new System.Drawing.Point(-1, 355);
            this.btnCarreras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCarreras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCarreras.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(219)))), ((int)(((byte)(196)))));
            this.btnCarreras.selected = false;
            this.btnCarreras.Size = new System.Drawing.Size(201, 76);
            this.btnCarreras.TabIndex = 21;
            this.btnCarreras.Text = "  Carreras";
            this.btnCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarreras.Textcolor = System.Drawing.Color.White;
            this.btnCarreras.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnprofesor
            // 
            this.btnprofesor.Activecolor = System.Drawing.Color.Transparent;
            this.btnprofesor.BackColor = System.Drawing.Color.Transparent;
            this.btnprofesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprofesor.BorderRadius = 0;
            this.btnprofesor.ButtonText = "  Profesores";
            this.btnprofesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprofesor.DisabledColor = System.Drawing.Color.Gray;
            this.btnprofesor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnprofesor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnprofesor.Iconimage")));
            this.btnprofesor.Iconimage_right = null;
            this.btnprofesor.Iconimage_right_Selected = null;
            this.btnprofesor.Iconimage_Selected = null;
            this.btnprofesor.IconMarginLeft = 0;
            this.btnprofesor.IconMarginRight = 0;
            this.btnprofesor.IconRightVisible = true;
            this.btnprofesor.IconRightZoom = 0D;
            this.btnprofesor.IconVisible = true;
            this.btnprofesor.IconZoom = 70D;
            this.btnprofesor.IsTab = false;
            this.btnprofesor.Location = new System.Drawing.Point(0, 278);
            this.btnprofesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprofesor.Name = "btnprofesor";
            this.btnprofesor.Normalcolor = System.Drawing.Color.Transparent;
            this.btnprofesor.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnprofesor.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(219)))), ((int)(((byte)(196)))));
            this.btnprofesor.selected = false;
            this.btnprofesor.Size = new System.Drawing.Size(200, 72);
            this.btnprofesor.TabIndex = 20;
            this.btnprofesor.Text = "  Profesores";
            this.btnprofesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprofesor.Textcolor = System.Drawing.Color.White;
            this.btnprofesor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Activecolor = System.Drawing.Color.Transparent;
            this.btnEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstudiante.BorderRadius = 0;
            this.btnEstudiante.ButtonText = "   Estudiantes";
            this.btnEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiante.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstudiante.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstudiante.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEstudiante.Iconimage")));
            this.btnEstudiante.Iconimage_right = null;
            this.btnEstudiante.Iconimage_right_Selected = null;
            this.btnEstudiante.Iconimage_Selected = null;
            this.btnEstudiante.IconMarginLeft = 0;
            this.btnEstudiante.IconMarginRight = 0;
            this.btnEstudiante.IconRightVisible = true;
            this.btnEstudiante.IconRightZoom = 0D;
            this.btnEstudiante.IconVisible = true;
            this.btnEstudiante.IconZoom = 70D;
            this.btnEstudiante.IsTab = false;
            this.btnEstudiante.Location = new System.Drawing.Point(0, 203);
            this.btnEstudiante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEstudiante.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEstudiante.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(219)))), ((int)(((byte)(196)))));
            this.btnEstudiante.selected = false;
            this.btnEstudiante.Size = new System.Drawing.Size(200, 68);
            this.btnEstudiante.TabIndex = 19;
            this.btnEstudiante.Text = "   Estudiantes";
            this.btnEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiante.Textcolor = System.Drawing.Color.White;
            this.btnEstudiante.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.MouseHover += new System.EventHandler(this.btnEstudiante_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabEstudiante);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.draging);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.draging.ResumeLayout(false);
            this.tabEstudiante.ResumeLayout(false);
            this.tabBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel draging;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private System.Windows.Forms.TabControl tabEstudiante;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.TabPage tabInfo;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstudiante;
        private Bunifu.Framework.UI.BunifuFlatButton btnprofesor;
        private Bunifu.Framework.UI.BunifuFlatButton btnCarreras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEstudiante;
        private System.Windows.Forms.Panel pnlProfesores;
        private System.Windows.Forms.Panel pnlCarreras;
        private System.Windows.Forms.Panel panel0;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.PictureBox picIconBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBusquedaEstudiante;
    }
}