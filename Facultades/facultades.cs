using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Academica.Facultades
{
    public partial class facultades : UserControl
    {
        public facultades()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }
    }
}
