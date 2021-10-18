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
        private string apellido;
        private string nombre;
        private int dni;
        private DateTime fechNac;
        private char sexo;
        #endregion
        #region Propiedades

        public string Apellido 
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechNac
        {
            get { return fechNac; }
            set { fechNac = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        #endregion
        #region Constructores
        public Persona()//por defecto
        { }
        public Persona(string Nom, int Dni, DateTime FecNac, char Sex)//Contructor hecho por el programador
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
