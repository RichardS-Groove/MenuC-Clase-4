using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuC
{
    public partial class Menu : Form
    {
        public DialogResult End { get; private set; }

        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proveedores ProveedoresForm = new Proveedores();
            ProveedoresForm.Show();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del sistema?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();            
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            Form clientesForm = new Clientes();
            clientesForm.ShowDialog();
        }

        private void bListados_Click(object sender, EventArgs e)
        {
            Form listadosForm = new Listados();
            listadosForm.ShowDialog();
        }

        private void bProveedores_Click(object sender, EventArgs e)
        {
            Form proveedoresForm = new Proveedores();
            proveedoresForm.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema?", "salir de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listadosForm = new Listados();
            listadosForm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form clientesForm = new Clientes();
            clientesForm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form proveedoresForm = new Proveedores();
            proveedoresForm.ShowDialog();
        }
    }
}
