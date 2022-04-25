using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            //declarar variables
            double total, descuento;
            //datos de entrada
            total = Convert.ToDouble(txtTotal.Text);
            //proceso
            descuento = total - 10;
            //salida
            if (total > 200)
                MessageBox.Show("El total de su compra con descuento es " + descuento, "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El total de su compra es " + total, "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = (MessageBox.Show("Desa salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
            if (respuesta == DialogResult.Yes)
            { this.Close(); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtTotal.Text = Convert.ToString("");
        }
    }
}
