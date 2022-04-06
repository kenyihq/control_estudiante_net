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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataEst.SelectedRows.Count > 0)
            {
                Editar = true;
                pNombre.Text = dataEst.CurrentRow.Cells[1].Value.ToString();
                sNombre.Text = dataEst.CurrentRow.Cells[2].Value.ToString();
                pApellido.Text = dataEst.CurrentRow.Cells[3].Value.ToString();
                sApellido.Text = dataEst.CurrentRow.Cells[4].Value.ToString();
                tel.Text = dataEst.CurrentRow.Cells[5].Value.ToString();
                cel.Text = dataEst.CurrentRow.Cells[6].Value.ToString();
                direccion.Text = dataEst.CurrentRow.Cells[7].Value.ToString();
                email.Text = dataEst.CurrentRow.Cells[8].Value.ToString();
                nac.Text = dataEst.CurrentRow.Cells[9].Value.ToString();
                obs.Text = dataEst.CurrentRow.Cells[10].Value.ToString();
            }
            else
            {
                MensajeError("Seleccione una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataEst.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar el registro", "Registro de estudiantes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.id_est = Convert.ToInt32(dataEst.CurrentRow.Cells[0].Value.ToString());
                    ObjNegocios.EliminarResgistros(ObjEntidad);

                    MensajeConfirmacion("Se elimino correctamente el registro");

                    MostrarRegistro();
                }
                else
                {
                    MensajeError("Seleccione un fila");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    ObjEntidad.primer_nombre = pNombre.Text.ToUpper();
                    ObjEntidad.segundo_nombre = sNombre.Text.ToUpper();
                    ObjEntidad.primer_apellido = pApellido.Text.ToUpper();
                    ObjEntidad.segundo_apellido = sApellido.Text.ToUpper();
                    ObjEntidad.telefono = tel.Text.ToUpper();
                    ObjEntidad.celular = cel.Text.ToUpper();
                    ObjEntidad.direccion = direccion.Text.ToUpper();
                    ObjEntidad.email = email.Text.ToUpper();
                    ObjEntidad.nacimiento = nac.Text;
                    ObjEntidad.observaciones = obs.Text;

                    ObjNegocios.InsertarRegistros(ObjEntidad);

                    MensajeConfirmacion("Se insertó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo ingresar el registro");
                }
            }
            if (Editar == true)
            {
                try
                {
                    
                    ObjEntidad.primer_nombre = pNombre.Text.ToUpper();
                    ObjEntidad.segundo_nombre = sNombre.Text.ToUpper();
                    ObjEntidad.primer_apellido = pApellido.Text.ToUpper();
                    ObjEntidad.segundo_apellido = sApellido.Text.ToUpper();
                    ObjEntidad.telefono = tel.Text.ToUpper();
                    ObjEntidad.celular = cel.Text.ToUpper();
                    ObjEntidad.direccion = direccion.Text.ToUpper();
                    ObjEntidad.email = email.Text.ToUpper();
                    ObjEntidad.nacimiento = nac.Text;
                    ObjEntidad.observaciones = obs.Text;

                    ObjNegocios.EditarRegsitro(ObjEntidad);

                    MensajeConfirmacion("Se modificó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MensajeError("No se pudo modificar el registro");
                }
            }
        }
    }
}
