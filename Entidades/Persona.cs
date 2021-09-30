using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private long dni;
        private DateTime fechNac;
        private string sexo;
        #endregion
        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechNac
        {
            get { return fechNac; }
            set { fechNac = value; }
        }
        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        #endregion
        #region Constructores
        public Persona()//por defecto
        { }
        public Persona(string Nom, long Dni, DateTime FecNac, string Sex)//Contructor hecho por el programador
        {
            nombre = Nom;
            dni = Dni;
            fechNac = FecNac;
            sexo = Sex;
        }
        #endregion
        #region Metodos
        public int Edad()
        {
            int edad;
            edad = FechNac.Year - DateTime.Now.Year;
            return edad;
        }
        #endregion
    }
}
