using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todeitor
{
    public class Fruta
    {
        #region Atributos
        public Int32 IdFruta { get; set; }
        public String Nombre { get; set; }
        public String Color { get; set; }
        public double Peso { get; set; }
        public bool Semilla { get; set; }
        public Int32 Origen { get; set; }
        #endregion

        public Fruta(Int32 id,String nombre, String color, double peso, bool sem, Int32 origen)
        {
            IdFruta = id;
            Nombre = nombre;
            Color = color;
            Peso = peso;
            Semilla = sem;
            Origen = origen;
        }

        public void ValidarFruta()
        {
            if(Semilla == false)
            {
                throw new Exception("No puedes Registrar frutas sin semillas");
            }
            else if(Origen == (int)Origenes.Internacional)
            {
                throw new Exception("No puedes registrar frutas internacionales");
            }
        }


    }
}
