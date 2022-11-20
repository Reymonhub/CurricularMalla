using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesMallaCurricular;

namespace FormulariosMallaCurricular
{
    public partial class frmFacultad : Form
    {
        private string ACCION;
        private const string NUEVO = "NUEVO";
        private const string EDITAR = "EDITAR";
        public frmFacultad()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                MessageBox.Show("Para buscar se debe ingresar el nombre de la facultad");
                return;
            }

            dgvFacultad.DataSource = null;
            dgvFacultad.DataSource = Facultad.BuscarFacultad(txtBuscar.Text);
        }

        private void Habilitar(bool Habilitado)
        {
            txtFacultad.Enabled = Habilitado;
            btnAceptar.Enabled = Habilitado;
            btnCancelar.Enabled = Habilitado;
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtBuscar.Clear();
            txtFacultad.Clear();
        }

        private void ActualizarDatagriv()
        {
            dgvFacultad.DataSource = null;
            dgvFacultad.DataSource = Facultad.ObtenerFacultades();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(true);
            ACCION = NUEVO;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
        }

        private void dgvFacultad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = (Facultad)dgvFacultad.CurrentRow.DataBoundItem;

            if(obj != null)
            {
                txtId.Text = obj.Id.ToString();
                txtFacultad.Text = obj.Nombre;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var obj = (Facultad)dgvFacultad.CurrentRow.DataBoundItem;

            if (obj != null)
            {
                Habilitar(true);
                ACCION = EDITAR;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                Facultad.Eliminar(id);
                Limpiar();
                ActualizarDatagriv();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var obj = new Facultad();
            obj.Nombre = txtFacultad.Text;
            var result = obj.Validar();

            if(result.IsValid)
            {
                if(ACCION == NUEVO)
                {
                    Facultad.Agregar(obj);
                }
                else if (ACCION == EDITAR)
                {
                    obj.Id = Convert.ToInt32(txtId.Text);
                    Facultad.Modificar(obj);
                }

                Limpiar();
                Habilitar(false);
                ActualizarDatagriv();
            }
            else
            {
                MessageBox.Show(result.Message, 
                    Constants.NombreSistema, 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmFacultad_Load(object sender, EventArgs e)
        {
            ActualizarDatagriv();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarDatagriv();
        }
    }
}
