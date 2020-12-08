using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_EL1_BRANDON_SOTO_MALLQUI
{
    public partial class FmrElecktra : Form
    {
        public FmrElecktra()
        {
            InitializeComponent();
        }
        ClsElecktra obj = new ClsElecktra();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            obj.lineaProducto = cboLinea.Text;
            obj.cantidad = int.Parse(txtCantidad.Text);
            obj.precioUnitario = double.Parse(txtPrecioUni.Text);
            txtImportVenta.Text = obj.importeVenta().ToString("n2");
            txtDescuento.Text = obj.Descuento().ToString("n2");
            txtNeto.Text = obj.NETO().ToString("n2");
            txtFlete.Text = obj.CostoFlete().ToString("n2");

            
        }

        private void FmrElecktra_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = obj.GeneraCodigo();
            obj.nomCliente = txtCliente.Text;
            obj.nombreProducto = txtProducto.Text;
           
            
        }
    }
}
