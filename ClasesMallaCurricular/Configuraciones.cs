using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClasesMallaCurricular
{
    public static class Configuraciones
    {
        public static string CADENA_CONEXION =
            ConfigurationManager.ConnectionStrings["PandaRosa"].ConnectionString;
    }
}