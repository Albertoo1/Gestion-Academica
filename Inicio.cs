using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Academica
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            {
                Application.ExitThread();
            }
        }

        private void acceso_Load(object sender, EventArgs e)
        {
           
        }

       //Comportamiento de los comboxbox
        private void txtUsuario_OnValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = global::Gestion_Academica.Properties.Resources.user_male_324A5E_shape;
            if (txtUsuario.Text == "")
            {
                pictureBox2.Image = global::Gestion_Academica.Properties.Resources.user_male_black_shape;
            }
        }

        private void txtContrase_OnValueChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = global::Gestion_Academica.Properties.Resources.lock_324A5E;
            if (txtContrase.Text == "")
            {
                pictureBox3.Image = global::Gestion_Academica.Properties.Resources._lock;
            }
        }
        private void txtContrase_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtContrase.Text == "Contraseña")
            {
                txtContrase.Text = "";
            }
        }
        private void chcisChanged_OnChange(object sender, EventArgs e)
        {
            txtContrase.isPassword = !chcisChanged.Checked;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
        }
    }
    }

