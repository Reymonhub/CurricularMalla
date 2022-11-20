using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosMallaCurricular
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmFacultad_Click(object sender, EventArgs e)
        {
            var frm = new frmFacultad();
            frm.Show();
        }
    }
}
