using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO;


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
            GridEstudiante.AutoGenerateColumns = false;
            gridMaterias.AutoGenerateColumns = false;
            gridParcialesNota.AutoGenerateColumns = false;
        }
        private void txtBusquedaEstudiante_OnValueChanged(object sender, EventArgs e)
        {
            picIconBusqueda.Image = Properties.Resources.magnifier;
            if (txtBusquedaEstudiante.Text == "")
            {
                picIconBusqueda.Image = Properties.Resources.magnifier_gray;
                GridEstudiante.DataSource = null;
            }else
            {
                DataView newdv = clsEstudiante.buscandoEstudiante(321).DefaultView;
                string filter;

                filter = char.IsNumber(txtBusquedaEstudiante.Text[0]) ? 
                         "Convert(carnet, System.String) LIKE '" + txtBusquedaEstudiante.Text + "%'": 
                         "fullName LIKE '%" + txtBusquedaEstudiante.Text + "%'";

                newdv.RowFilter = filter;
                GridEstudiante.DataSource = newdv;       
            }
            
        }

        private void GridEstudiante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Int64 carnet = Convert.ToInt64(GridEstudiante.CurrentRow.Cells[0].Value);
            DataTable[] dt = clsEstudiante.infoEstudiante(carnet);

            DataRow Info = dt[0].Rows[0];
            int Emails = dt[1].Rows.Count;
            int Celular = dt[2].Rows.Count;

            //Cargano informacion en los texbox

            chcActivo.Checked = Convert.ToBoolean(Info["activo"]);
            txtNombres.Text = Info["nombres"].ToString();
            txtApellidos.Text = Info["apellidos"].ToString();
            txtCedula.Text = Info["cedula"].ToString();
            txtEstadoCivil.Text = Info["estadoCivil"].ToString();
            txtSexo.Text = Info["sexo"].ToString();
            txtDepartamento.Text = Info["nombreDepar"].ToString();
            txtCiudad.Text = Info["Municipio"].ToString();
            txtDireccion.Text = Info["direccion"].ToString();
            txtNCarnet.Text = Info["carnet"].ToString();
            txtCarrera.Text = Info["carrera"].ToString();
            txtSede.Text = Info["sede"].ToString();
            txtModalidad.Text = Info["modalidad"].ToString();
            txtTurno.Text = Info["turno"].ToString();
            txtPeriodo.Text = Info["periodo"].ToString();

            if (Emails > 0)
            {
                int iSize = 22;
                int newPositionY = 306;
                string[] fill = new string[Emails];

                for (int i = 0; i < Emails; i++)
                {
                    fill[i] = dt[1].Rows[i]["email1"].ToString();
                    pnlInfoInscrip.Location = new Point(pnlInfoInscrip.Location.X, newPositionY);
                    txtEmail.Size = new Size(371, iSize);
                    iSize += 22;
                    newPositionY += 18;
                }

                txtEmail.Lines = fill;
            }
            else { txtEmail.Text = "No Email"; }


            if (Celular > 0)
            {
                for (int i = 0; i < Celular; i++)
                {
                    txtCelular.Text += dt[2].Rows[i]["n_celular"].ToString();
                    txtCelular.Text += i != (Celular - 1) ? "  " : "";
                }
            }
            else { txtCelular.Text = "No Cell"; }

            tabEstudiante.SelectedIndex = 1;

            gridMaterias.DataSource = clsEstudiante.materias(carnet);


        }

        private void tabEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBusquedaMateria_OnValueChanged(object sender, EventArgs e)
        {
            picIconBusquedaMateria.Image = Properties.Resources.magnifier;
            if(txtBusquedaMateria.Text == String.Empty)
            {
                picIconBusquedaMateria.Image = Properties.Resources.magnifier_gray;
            } else {

                DataView dt = gridMaterias.DataSource as DataView;

                //dt.RowFilter = "nombre LIKE '";
            }
        }

    }
}

