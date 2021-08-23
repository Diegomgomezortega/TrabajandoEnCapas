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
        DatosProfesionales objDatosProfesionales = new DatosProfesionales();
        public int abmProfesionales(string accion, Profesional objProfesional)
        {
            return objDatosProfesionales.abmProfesionales(accion, objProfesional);
        }
        public DataSet listadoProfesionales(string cual)
        {
            return objDatosProfesionales.listadoProfesionales(cual);
        }
    }
}
