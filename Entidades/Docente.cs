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
        private string codProf;
        #endregion
        #region Constructores
        public Docente()//Vacio, no trae ningun argumento/parametro
        {
        }
        public Docente(string Nom,long Du,DateTime FecNac,char Sex)//No inicializa materia ni codProf
        {

        }
        public Docente(string Nom, long Du, DateTime FecNac, char Sex, string Mat, string Cod) : base(Nom, Du, FecNac, Sex)
        {
            materia = Mat;
            codProf = Cod;

        }//Inicializa materia=mat y codProf=Cod
        #endregion
        #region propiedades/encapsulamiento
        public string CodProf
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
