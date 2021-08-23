using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    
    public class DatosConexionBD
    {
        #region Atributos
        public SqlConnection conexion;
        public string Cadenaconexion = "Data Source=DESKTOP-UM2AVUB\\SQLEXPRESS;Initial Catalog=PruebaDb;Integrated Security=True";
        #endregion
        #region Contructor
        public DatosConexionBD()
        {
            conexion = new SqlConnection(Cadenaconexion);
        }
        #endregion
        #region Metodos de Apertura y Cierre de conexion
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
        #endregion
    }
}
    

