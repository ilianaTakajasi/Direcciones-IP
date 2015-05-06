using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using direcciones.direccion;

namespace direcciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        direccionIPSoapClient ip = new direccionIPSoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdire.Text != string.Empty && txtdire1.Text != string.Empty && txtdire2.Text != string.Empty && txtdire3.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show(ip.direccion(int.Parse(txtdire.Text)));
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("La direccion no pertenece a ninguna de las clases A B o C o introduce correctamenta la direccion", ex.Message);
                }
            }
            else 
            {
                MessageBox.Show( "Es necesario llenar todos los campos necesarios de la DIRECCION IP");
            }
        }
    }
}
