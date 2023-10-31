using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDgUsuarios frm = new frmDgUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDgProductos frm = new frmDgProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDgVenta frm = new frmDgVenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDgProductoVendido frm = new frmDgProductoVendido();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
