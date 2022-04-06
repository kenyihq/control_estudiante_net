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

        private void closePic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEstudiantes_Load(object sender, EventArgs e)
        {

        }
    }
}
