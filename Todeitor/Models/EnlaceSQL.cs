using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todeitor
{
    public class EnlaceSQL
    {
        #region Atributos
        private SqlConnection enlace { get; set; }
        private SqlDataAdapter dAdapter { get; set; }
        private DataTable dTable { get; set; }
        private string query { get; set; }
        #endregion

        public EnlaceSQL()
        {
            enlace = new SqlConnection( Properties.Settings.Default.CadenaTodeitor);
        }

        public void prueba(Fruta frutita)
        {
            MessageBox.Show(frutita.Nombre.ToString());
            MessageBox.Show(frutita.Color.ToString());
            MessageBox.Show(frutita.Peso.ToString());
            MessageBox.Show(frutita.Semilla.ToString());
            MessageBox.Show(frutita.Origen.ToString());
        }
        public void prueba2()
        {
            enlace.Open();

        }


    }
}
