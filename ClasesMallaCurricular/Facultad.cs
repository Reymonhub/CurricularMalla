using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMallaCurricular
{
    public class Facultad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        private static List<Facultad> Lista = new List<Facultad>();

        public override string ToString()
        {
            return $"{Nombre}";
        }

        public ValidationResponse Validar()
        {
            var response = new ValidationResponse();
            if(String.IsNullOrWhiteSpace(Nombre))
            {
                response.IsValid = false;
                response.Message = "El nombre de la facultad no puede estar en blanco";
            }
            else
            {
                response.IsValid = true;
            }

            return response;
        }

        public static bool Agregar(Facultad obj)
        {
            using(var con = new SqlConnection(Configuraciones.CADENA_CONEXION))
            {
                con.Open();
                var sql = @"
                    INSERT INTO Facultad
                           (Nombre)
                    VALUES
                           (@Nombre)
                ";

                var cmd = new SqlCommand(sql, con);
                cmd = ObtenerParametro(cmd, obj);

                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static bool Modificar(Facultad obj)
        {
            using(var con = new SqlConnection(Configuraciones.CADENA_CONEXION))
            {
                con.Open();
                var sql = @"
                    UPDATE Facultad SET
                    Nombre = @Nombre
                    WHERE Id = @Id
                ";
                var cmd = new SqlCommand(sql, con);
                cmd = ObtenerParametro(cmd, obj);
                cmd = ObtenerParametroId(cmd, obj.Id);

                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static bool Eliminar(int id)
        {
            using(var con = new SqlConnection(Configuraciones.CADENA_CONEXION))
            {
                con.Open();
                var sql = "DELETE FROM Facultad WHERE Id = @Id";
                var cmd = new SqlCommand(sql, con);
                cmd = ObtenerParametroId(cmd, id);
                
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static List<Facultad> ObtenerFacultades()
        {
            Facultad facultad;
            Lista.Clear();
            using(var con = new SqlConnection(Configuraciones.CADENA_CONEXION))
            {
                con.Open();
                string sql = "SELECT * from Facultad";
                var cmd = new SqlCommand(sql, con);
                var lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    facultad = new Facultad();
                    facultad.Id = lector.GetInt32(0);
                    facultad.Nombre= lector.GetString(1);

                    Lista.Add(facultad);
                }

                return Lista;
            }
        }
        public static List<Facultad> BuscarFacultad(string facu)
        {
            Facultad facultad;
            Lista.Clear();
            using (var con = new SqlConnection(Configuraciones.CADENA_CONEXION))
            {
                con.Open();
                string sql = "SELECT * from Facultad WHERE Nombre = @Nombre";
                var cmd = new SqlCommand(sql, con);
                cmd = ObtenerBusqueda(cmd, facu);

                var lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    facultad = new Facultad();
                    facultad.Id = lector.GetInt32(0);
                    facultad.Nombre = lector.GetString(1);

                    Lista.Add(facultad);
                }

                return Lista;
            }
        }
        private static SqlCommand ObtenerParametro(SqlCommand cmd, Facultad obj)
        {
            var p1 = new SqlParameter("@Nombre", obj.Nombre);
            p1.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(p1);
            return cmd;
        }

        private static SqlCommand ObtenerParametroId(SqlCommand cmd, int id)
        {
            var p1 = new SqlParameter("@Id", id);
            p1.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);

            return cmd;
        }

        private static SqlCommand ObtenerBusqueda(SqlCommand cmd, string facu)
        {
            var p1 = new SqlParameter("@Nombre", facu);
            p1.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);

            return cmd;
        }
    }
}
