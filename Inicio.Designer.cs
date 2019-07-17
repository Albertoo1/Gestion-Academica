namespace Gestion_Academica
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnFrogotpass = new System.Windows.Forms.Label();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContrase = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.chcisChanged = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(47, 80);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(382, 28);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Sistema de Gestión Académica";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 32);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsalir.Location = new System.Drawing.Point(448, -1);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(53, 33);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnFrogotpass
            // 
            this.btnFrogotpass.AutoSize = true;
            this.btnFrogotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrogotpass.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnFrogotpass.ForeColor = System.Drawing.Color.Gray;
            this.btnFrogotpass.Location = new System.Drawing.Point(37, 399);
            this.btnFrogotpass.Name = "btnFrogotpass";
            this.btnFrogotpass.Size = new System.Drawing.Size(187, 17);
            this.btnFrogotpass.TabIndex = 5;
            this.btnFrogotpass.Text = "¿Olvidaste Tu Contraseña?";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtUsuario.HintText = "Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtUsuario.LineThickness = 4;
            this.txtUsuario.Location = new System.Drawing.Point(41, 297);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.Size = new System.Drawing.Size(414, 42);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.OnValueChanged += new System.EventHandler(this.txtUsuario_OnValueChanged);
            // 
            // txtContrase
            // 
            this.txtContrase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtContrase.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtContrase.HintText = "";
            this.txtContrase.isPassword = true;
            this.txtContrase.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtContrase.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtContrase.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.txtContrase.LineThickness = 4;
            this.txtContrase.Location = new System.Drawing.Point(41, 350);
            this.txtContrase.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrase.Name = "txtContrase";
            this.txtContrase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrase.Size = new System.Drawing.Size(414, 42);
            this.txtContrase.TabIndex = 2;
            this.txtContrase.Text = "Contraseña";
            this.txtContrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrase.OnValueChanged += new System.EventHandler(this.txtContrase_OnValueChanged);
            this.txtContrase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrase_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Gestion_Academica.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(430, 359);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Gestion_Academica.Properties.Resources.user_male_black_shape;
            this.pictureBox2.Location = new System.Drawing.Point(428, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.ActiveBorderThickness = 1;
            this.btnIngresar.ActiveCornerRadius = 20;
            this.btnIngresar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(116)))));
            this.btnIngresar.ActiveForecolor = System.Drawing.Color.White;
            this.btnIngresar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(116)))));
            this.btnIngresar.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.ButtonText = "Ingresar";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.IdleBorderThickness = 1;
            this.btnIngresar.IdleCornerRadius = 20;
            this.btnIngresar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnIngresar.IdleForecolor = System.Drawing.Color.White;
            this.btnIngresar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnIngresar.Location = new System.Drawing.Point(41, 446);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(414, 56);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // chcisChanged
            // 
            this.chcisChanged.BackColor = System.Drawing.Color.LightGray;
            this.chcisChanged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chcisChanged.ChechedOffColor = System.Drawing.Color.LightGray;
            this.chcisChanged.Checked = false;
            this.chcisChanged.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(116)))));
            this.chcisChanged.ForeColor = System.Drawing.Color.White;
            this.chcisChanged.Location = new System.Drawing.Point(293, 397);
            this.chcisChanged.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chcisChanged.Name = "chcisChanged";
            this.chcisChanged.Size = new System.Drawing.Size(20, 20);
            this.chcisChanged.TabIndex = 27;
            this.chcisChanged.OnChange += new System.EventHandler(this.chcisChanged_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(319, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mostrar Contraseña";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(497, 569);
            this.Controls.Add(this.btnFrogotpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chcisChanged);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sist. Gestión Académica";
            this.Load += new System.EventHandler(this.acceso_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label btnFrogotpass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContrase;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCheckbox chcisChanged;
        private System.Windows.Forms.Label label1;
    }
}

