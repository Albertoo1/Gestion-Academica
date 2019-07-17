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
    public partial class Menu : Form
    {
        public Menu()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
                Application.ExitThread();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void btnEstudiante_MouseHover(object sender, EventArgs e)
        {
            pnlEstudiante.BackColor = System.Drawing.Color.Black;
        }
        private void txtBusquedaEstudiante_OnValueChanged(object sender, EventArgs e)
        {
            picIconBusqueda.Image = global::Gestion_Academica.Properties.Resources.magnifier;
            if (txtBusquedaEstudiante.Text == "")
            {
                picIconBusqueda.Image = global::Gestion_Academica.Properties.Resources.magnifier_gray;
            }
        }

        
    }
}

