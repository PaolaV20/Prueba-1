using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todeitor
{
    public class Controller
    {
        public Controller() { }


        public void registrar(string nombre, string color, double peso, bool semilla,Int32 ori)
        {
            Fruta frutis = new Fruta(0, nombre, color, peso, semilla,ori);
            EnlaceSQL sql = new EnlaceSQL();
            try
            {
                frutis.ValidarFruta();
                sql.prueba(frutis);
                MessageBox.Show("Fruta registrada");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
