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
    public class NegProfesionales
    {
        DatosDocentes objDatosDocente = new DatosDocentes();
        public int abmDocentes(string accion, Docente objDocente)
        {
            return objDatosDocente.abmDocentes(accion, objDocente);
        }
        public DataSet listadoDocentes(string cual)
        {
            return objDatosDocente.listadoDocentes(cual);
        }
    }
}
