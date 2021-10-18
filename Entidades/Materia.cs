using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        #region Atributos
        private string nombre;
        private string cod_Mat;
        private int año;
        #endregion
        #region Constructor
        public Materia(string nom, string codmat,int a)
        {
            Nombre = nom;
            Cod_Mat = codmat;
            Año = a;
        }
        #endregion
        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Cod_Mat
        {
            get { return cod_Mat; }
            set { cod_Mat = value; }
        }
        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        #endregion

    }
}
