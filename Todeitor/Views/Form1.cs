using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todeitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComStatus.DataSource = Enum.GetValues(typeof(Origenes));
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Controller con = new Controller();

            con.registrar(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), checkBox1.Checked, (int) ComStatus.SelectedValue);
        }
    }
}
