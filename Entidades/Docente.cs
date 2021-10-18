using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente: Persona
    {
        #region atributos
        private string materia;
        private int codProf;
        #endregion
        #region Constructores
        public Docente()//Vacio, no trae ningun argumento/parametro
        {
        }
        public Docente( string mat, int cd)//No inicializa materia ni codProf
        {
            mat = materia;
            cd = codProf;
        }
        public Docente(string Nom, int Du, DateTime FecNac, char Sex, string Mat, int Cod) : base(Nom, Du, FecNac, Sex)
        {
            Nombre = Nom;
            Dni= Du;
            FechNac = FecNac;
            Sexo = Sex;
            materia = Mat;
            codProf = Cod;


        }//Inicializa todos los atributos, y los de la base Personas tambien
        #endregion
        #region propiedades/encapsulamiento
        public int CodProf
        {
            get { return codProf; }
            set { codProf = value; }
        }
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

       

        #endregion

    }
}
