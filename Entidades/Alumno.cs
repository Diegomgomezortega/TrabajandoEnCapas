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
        public Alumno(string carr, long leg)//Inicializa solo carrera y legajo
        {
            legajo = leg;
            carrera = carr;
        }
        public Alumno(string Nom, long Du, DateTime FecNac, string Sex, string carr, long leg) : base(Nom, Du, FecNac, Sex)
        {
            Nombre = Nom;
            Dni = Du;
            FechNac = FecNac;
            Sexo = Sex;
            legajo = leg;
            carrera=carr;


        }//Inicializa todos los atributos, y los de la base Personas tambien
        #endregion
    }
}

