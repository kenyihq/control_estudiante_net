using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Datos;
using Entidades;

namespace Negocios
{
    public class n_estudiante
    {
        readonly d_estudintes ObjEstudiantes = new d_estudintes();

        public static DataTable MostrarResgistro()
        {
            return new d_estudintes().MostrarRegistro();
        }

        public void InsertarRegistros(Estudiantes estud)
        {
            ObjEstudiantes.InsertarEstudiante(estud);
        }

        public void EditarRegsitro(Estudiantes estud)
        {
            ObjEstudiantes.EditarEstudiante(estud);
        }

        public void EliminarResgistros(Estudiantes estud)
        {
            ObjEstudiantes.EliminarEstudinte(estud);
        }
    }
}
