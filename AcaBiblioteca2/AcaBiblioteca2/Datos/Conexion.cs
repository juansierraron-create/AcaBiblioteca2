using MathNet.Numerics;
using Microsoft.Data.SqlClient;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcaBiblioteca2.Datos
{
    public class Conexion
    {
        private string cadenaConexion = "Data Source=.\\SQL2022;Database=AcaBiblioteca;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

    }

}