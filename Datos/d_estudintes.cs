using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using Entidades;

namespace Datos
{
    public class d_estudintes
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable MostrarRegistro()
        {
            DataTable dtResultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("mostrar_estudiante", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(dtResultado);

            return dtResultado;
        }

        public void InsertarEstudiante(Estudiantes estud)
        {
            SqlCommand SqlCmd = new SqlCommand("insertar_estudiante", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@primer_nombre", estud.primer_nombre);
            SqlCmd.Parameters.AddWithValue("@segundo_nombre", estud.segundo_nombre);
            SqlCmd.Parameters.AddWithValue("@primer_apellido", estud.primer_apellido);
            SqlCmd.Parameters.AddWithValue("@segundo_apellido", estud.segundo_apellido);
            SqlCmd.Parameters.AddWithValue("@telefono", estud.telefono);
            SqlCmd.Parameters.AddWithValue("@celular", estud.celular);
            SqlCmd.Parameters.AddWithValue("@direccion", estud.direccion);
            SqlCmd.Parameters.AddWithValue("@email", estud.email);
            SqlCmd.Parameters.AddWithValue("@nacimiento", estud.nacimiento);
            SqlCmd.Parameters.AddWithValue("@observaciones", estud.observaciones);
            SqlCmd.ExecuteNonQuery();

            conectar.Close();

        }

        public void EditarEstudiante(Estudiantes estud)
        {
            SqlCommand SqlCmd = new SqlCommand("editar_estudiante", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            SqlCmd.Parameters.AddWithValue("@id_estudiante", estud.id_est);
            SqlCmd.Parameters.AddWithValue("@primer_nombre", estud.primer_nombre);
            SqlCmd.Parameters.AddWithValue("@segundo_nombre", estud.segundo_nombre);
            SqlCmd.Parameters.AddWithValue("@primer_apellido", estud.primer_apellido);
            SqlCmd.Parameters.AddWithValue("@segundo_apellido", estud.segundo_apellido);
            SqlCmd.Parameters.AddWithValue("@telefono", estud.telefono);
            SqlCmd.Parameters.AddWithValue("@celular", estud.celular);
            SqlCmd.Parameters.AddWithValue("@direccion", estud.direccion);
            SqlCmd.Parameters.AddWithValue("@email", estud.email);
            SqlCmd.Parameters.AddWithValue("@nacimiento", estud.nacimiento);
            SqlCmd.Parameters.AddWithValue("@observaciones", estud.observaciones);
            SqlCmd.ExecuteNonQuery();

            conectar.Close();


        }
    }
}
