using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        #region Atributos
        private string carrera;
        private long legajo;
        #endregion
        #region Propiedades
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public long Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        #endregion
        #region Constructores
        public Alumno()//Constructor por defecto
        {

        }
        public Alumno(string Nom, long Du, DateTime FecNac, char Sex)//No inicializa carrera ni legajo
        {

        }
        public Alumno(string Nom, long Du, DateTime FecNac, char Sex, string Carr, long Leg) : base(Nom, Du, FecNac, Sex)//Constructor hecho por el programador
        {
            Carrera = Carr;//Trae en el constructor el argumento string Carr, y Carrera toma su valor
            Legajo = Leg;////Trae en el constructor el argumento string Leg, y Legajo toma su valor
        }
        #endregion
    }
}

