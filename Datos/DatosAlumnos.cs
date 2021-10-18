using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosAlumnos: DatosConexionBD
    {
        
        
           #region Metodo ABM Alumno
           public int abmAlumno(string accion, Alumno objalumno)
           {
               int resultado = -1;
               string orden = string.Empty;
               if (accion == "Alta")
                   orden = "insert into Alumnos values (" + objalumno.Dni + ",'" + objalumno.Nombre + "','" + objalumno.Apellido + "','" + objalumno.Carrera + "','" + objalumno.Sexo + "','" + objalumno.FechNac + "')";
               if (accion == "Modificar")
                   orden = "update Alumnos set DNI=" + objalumno.Dni + " ,Nombre ='" + objalumno.Nombre + "',Apellido='" + objalumno.Apellido + "',Carrera='" + objalumno.Carrera + "',Genero='" + objalumno.Sexo + "',FechaNac='" + objalumno.FechNac + "' where Legajo=" + objalumno.Legajo + " ";
               //UPDATE nombre_tabla SET columna1 = valor1, columna2 = valor2 WHERE columna3 = valor3
               if (accion == "Borrar")
                   orden = "delete from Alumnos  where Legajo=" + objalumno.Legajo + "";
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
                       throw new Exception("Error al tratar de guardar,borrar o modificar estudiantes", e);
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
           public DataSet listadoAlumnos(string cual)//Este método listadoAlumnos devuelve un DataSet ds con los registros solicitados,recibe un string que indica el código que deseo buscar, o si sesolicitan “Todos”
           {
               string orden = string.Empty;
               if (cual != "Todos")
                   orden = "select * from Alumnos where Legajo = " + int.Parse(cual) + ";";
               else
                   orden = "select * from Alumnos;";
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
                   throw new Exception("Error al listar Alumnos", e);
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
