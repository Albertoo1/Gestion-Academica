namespace Gestion_Academica.Pageprofesores
{
    partial class profesores
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profesores));
            this.btnregresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbo2 = new System.Windows.Forms.GroupBox();
            this.btnactualizarprofesor = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnagregarprofesor = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtapellidoprofe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbofacultad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidprofe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.txtcontactoprofe = new System.Windows.Forms.TextBox();
            this.txtcelprofe = new System.Windows.Forms.TextBox();
            this.txtnombreprofe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.btnregresar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualizarprofesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregarprofesor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.IndianRed;
            this.btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("btnregresar.Image")));
            this.btnregresar.ImageActive = null;
            this.btnregresar.Location = new System.Drawing.Point(362, 2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(50, 40);
            this.btnregresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnregresar.TabIndex = 57;
            this.btnregresar.TabStop = false;
            this.btnregresar.Zoom = 10;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 512);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.gbo2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1011, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profesores";
            // 
            // gbo2
            // 
            this.gbo2.BackColor = System.Drawing.Color.Honeydew;
            this.gbo2.Controls.Add(this.btnactualizarprofesor);
            this.gbo2.Controls.Add(this.btnagregarprofesor);
            this.gbo2.Controls.Add(this.txtapellidoprofe);
            this.gbo2.Controls.Add(this.label2);
            this.gbo2.Controls.Add(this.cbofacultad);
            this.gbo2.Controls.Add(this.label4);
            this.gbo2.Controls.Add(this.txtidprofe);
            this.gbo2.Controls.Add(this.label1);
            this.gbo2.Controls.Add(this.txtespecialidad);
            this.gbo2.Controls.Add(this.txtcontactoprofe);
            this.gbo2.Controls.Add(this.txtcelprofe);
            this.gbo2.Controls.Add(this.txtnombreprofe);
            this.gbo2.Controls.Add(this.label8);
            this.gbo2.Controls.Add(this.label12);
            this.gbo2.Controls.Add(this.label18);
            this.gbo2.Controls.Add(this.label19);
            this.gbo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo2.ForeColor = System.Drawing.Color.Green;
            this.gbo2.Location = new System.Drawing.Point(6, 22);
            this.gbo2.Name = "gbo2";
            this.gbo2.Size = new System.Drawing.Size(999, 252);
            this.gbo2.TabIndex = 45;
            this.gbo2.TabStop = false;
            this.gbo2.Text = "Datos";
            // 
            // btnactualizarprofesor
            // 
            this.btnactualizarprofesor.BackColor = System.Drawing.Color.Transparent;
            this.btnactualizarprofesor.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizarprofesor.Image")));
            this.btnactualizarprofesor.ImageActive = null;
            this.btnactualizarprofesor.Location = new System.Drawing.Point(469, 200);
            this.btnactualizarprofesor.Name = "btnactualizarprofesor";
            this.btnactualizarprofesor.Size = new System.Drawing.Size(75, 52);
            this.btnactualizarprofesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnactualizarprofesor.TabIndex = 61;
            this.btnactualizarprofesor.TabStop = false;
            this.btnactualizarprofesor.Zoom = 10;
            // 
            // btnagregarprofesor
            // 
            this.btnagregarprofesor.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarprofesor.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarprofesor.Image")));
            this.btnagregarprofesor.ImageActive = null;
            this.btnagregarprofesor.Location = new System.Drawing.Point(357, 200);
            this.btnagregarprofesor.Name = "btnagregarprofesor";
            this.btnagregarprofesor.Size = new System.Drawing.Size(75, 52);
            this.btnagregarprofesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnagregarprofesor.TabIndex = 60;
            this.btnagregarprofesor.TabStop = false;
            this.btnagregarprofesor.Zoom = 10;
            // 
            // txtapellidoprofe
            // 
            this.txtapellidoprofe.Location = new System.Drawing.Point(562, 65);
            this.txtapellidoprofe.Name = "txtapellidoprofe";
            this.txtapellidoprofe.Size = new System.Drawing.Size(264, 24);
            this.txtapellidoprofe.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(462, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Apellidos";
            // 
            // cbofacultad
            // 
            this.cbofacultad.FormattingEnabled = true;
            this.cbofacultad.Location = new System.Drawing.Point(562, 160);
            this.cbofacultad.Name = "cbofacultad";
            this.cbofacultad.Size = new System.Drawing.Size(193, 26);
            this.cbofacultad.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(462, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Facultad";
            // 
            // txtidprofe
            // 
            this.txtidprofe.Location = new System.Drawing.Point(166, 24);
            this.txtidprofe.Name = "txtidprofe";
            this.txtidprofe.Size = new System.Drawing.Size(154, 24);
            this.txtidprofe.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Profesor";
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Location = new System.Drawing.Point(163, 160);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.Size = new System.Drawing.Size(193, 24);
            this.txtespecialidad.TabIndex = 28;
            // 
            // txtcontactoprofe
            // 
            this.txtcontactoprofe.Location = new System.Drawing.Point(163, 111);
            this.txtcontactoprofe.Name = "txtcontactoprofe";
            this.txtcontactoprofe.Size = new System.Drawing.Size(246, 24);
            this.txtcontactoprofe.TabIndex = 25;
            // 
            // txtcelprofe
            // 
            this.txtcelprofe.Location = new System.Drawing.Point(562, 113);
            this.txtcelprofe.Name = "txtcelprofe";
            this.txtcelprofe.Size = new System.Drawing.Size(154, 24);
            this.txtcelprofe.TabIndex = 22;
            // 
            // txtnombreprofe
            // 
            this.txtnombreprofe.Location = new System.Drawing.Point(166, 65);
            this.txtnombreprofe.Name = "txtnombreprofe";
            this.txtnombreprofe.Size = new System.Drawing.Size(264, 24);
            this.txtnombreprofe.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(46, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Especialidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(474, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Celular";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(75, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Contacto";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(66, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Nombres";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1011, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "In";
            // 
            // profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.tabControl1);
            this.Name = "profesores";
            this.Size = new System.Drawing.Size(1025, 518);
            ((System.ComponentModel.ISupportInitialize)(this.btnregresar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbo2.ResumeLayout(false);
            this.gbo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualizarprofesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregarprofesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnregresar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbo2;
        private System.Windows.Forms.TextBox txtapellidoprofe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbofacultad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidprofe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.TextBox txtcontactoprofe;
        private System.Windows.Forms.TextBox txtcelprofe;
        private System.Windows.Forms.TextBox txtnombreprofe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuImageButton btnactualizarprofesor;
        private Bunifu.Framework.UI.BunifuImageButton btnagregarprofesor;
    }
}
