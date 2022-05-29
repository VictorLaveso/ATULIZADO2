using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora
{
    public partial class Seguros : Form
    {
        public Seguros()
        {
            InitializeComponent();
            
           /* for (int x = 1; x < 10; x++)
            {
                cbc_Cliente.Items.Add("Opção " + x.ToString());
            }
           */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarSegurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SeguroCarro seguroCarro = new frm_SeguroCarro();
            seguroCarro.ShowDialog();
        }

        private void Seguros_Load(object sender, EventArgs e)
        {
           // lblUsuario.Text = "Usuario:" txtLogin.Text;
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadCliente CadCliente = new frm_CadCliente();
            CadCliente.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AlterarCliente alterarCliente = new frm_AlterarCliente();
            alterarCliente.ShowDialog();
        }

        private void sobreOSitemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sobre telasobre = new frm_Sobre();
            telasobre.ShowDialog();
        }
    }
}
