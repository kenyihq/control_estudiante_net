using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Negocios;

namespace Presentation
{
    public partial class FormEstudiantes : Form
    {
        private bool Editar = false;
        readonly Estudiantes ObjEntidad = new Estudiantes();
        readonly n_estudiante ObjNegocios = new n_estudiante();
        public FormEstudiantes()
        {
            InitializeComponent();
        }

        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Registro de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarRegistro()
        {
            dataEst.DataSource = n_estudiante.MostrarResgistro();
        }

        public void LimpiarCajas()
        {
            Editar = false;
            pNombre.Text = "";
            sNombre.Text = "";
            pApellido.Text = "";
            sApellido.Text = "";
            tel.Text = "";
            cel.Text = "";
            direccion.Text = "";
            email.Text = "";
            nac.Text = "";
            obs.Text = "";
            pNombre.Focus();
        }
        private void closePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEstudiantes_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void dataEst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
