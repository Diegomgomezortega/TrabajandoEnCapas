using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using Entidades;

namespace Datos
{
    public class DatosDocentes: DatosConexionBD
    {
        #region Metodo abm Docente

        public int abmDocentes(string accion, Docente objDocente)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Docente values (" + objDocente.Dni + ",'" + objDocente.Nombre + "','" + objDocente.Apellido + "','" + objDocente.Sexo + "','" + objDocente.FechNac.Year + "/" + objDocente.FechNac.Date.Month + "/" + objDocente.FechNac.Date.Day + "','" + objDocente.Materia + "')";
            if (accion == "Modificar")
                orden = "update Docente set Dni=" + objDocente.Dni + " ,Nombre ='"+ objDocente.Nombre + "',Apellido='"+objDocente.Apellido+"',Materia='" + objDocente.Materia + "',Genero='" + objDocente.Sexo + "',FechaNacimiento='" + objDocente.FechNac.Year + "/" + objDocente.FechNac.Date.Month + "/" + objDocente.FechNac.Date.Day + "' where CodProf=" + objDocente.CodProf + " ";
            //UPDATE nombre_tabla SET columna1 = valor1, columna2 = valor2 WHERE columna3 = valor3
            if (accion == "Borrar")
                orden = "delete from Docente  where CodProf=" + objDocente.CodProf + "";
            //DELETE FROM nombre_tabla WHERE nombre_columna = valor
            SqlCommand cmd = new SqlCommand(orden, conexion);
            {
                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al tratar de guardar,borrar o modificar de Docentes",e);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
                return resultado;
            }
        }
        #endregion
       
        public DataSet listadoDocentes(string cual)//Este método listadoDocentes devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Docente where CodProf = " + int.Parse(cual) + ";";
            else
                orden = "select * from Docente;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Docentes", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
    

}
