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
    public partial class frm_SeguroCarro : Form
    {
        public frm_SeguroCarro()
        {
            InitializeComponent();

        }

        private void frm_SeguroCarro_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_Sim_CheckedChanged(object sender, EventArgs e)
        {
            txtNome2.Enabled = true;
            txtCPF2.Enabled = true;
            panel_SegundoSegurado.Visible = true;
        }

        private void btn_CancelarSegundo_Click(object sender, EventArgs e)
        {
            checkBox_Sim.Controls.Clear();
            txtNome2.Enabled = false;
            txtCPF2.Enabled = false;
            checkBox_Sim.Visible = true;
            checkBox_Sim.Checked = false;
            panel_SegundoSegurado.Visible = false;
        }

        private void btnSalvarSeguros_Click(object sender, EventArgs e)
        {
            Seguro seguro = Recuperar_Informacao_Tela_Seguro();
            //validar cliente
            bool v = validar_seguro(seguro);
            if (v)
            {
                //verdadeiro vai salvar
                //chamar o metodo de salvar
            }
            else
            {
                //nao salvar e mandar mensagem

            }
        }


        private bool validar_seguro(Seguro seguro)
        {
            if (seguro.Modelocarro.Equals(""))
            {
                MessageBox.Show("O campo Modelo do Carro está em branco !! \nEscolha uma opção !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbc_Carro.Focus();
                return false;
            }
            if (seguro.Placa.Equals(""))
            {
                MessageBox.Show("O campo Placa está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlacaCarro.Focus();
                return false;
            }
            if (seguro.Chassi.Equals(""))
            {
                MessageBox.Show("O campo Chassi está em braco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChassiCarro.Focus();
                return false;
            }
            if (seguro.Cor.Equals(""))

            {
                MessageBox.Show("O campo Cor do Carro está em branco !! \nEscolha uma opção !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbc_CorCarro.Focus();
                return false;
            }
            if (seguro.Ano.Equals(""))
            {
                MessageBox.Show("O campo Ano do Carro está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnoCarro.Focus();
                return false;
            }

            if (seguro.Valor.Equals(""))

            {
                MessageBox.Show("O campo Valor do Carro está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCarro.Focus();
                return false;
            }

            if (seguro.Crv.Equals(""))

            {
                MessageBox.Show("O campo CRV (Certificado de Registro do Veiculo) está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if (seguro.Crlv.Equals(""))

            {
                MessageBox.Show("O campo CRLV (Certificado de Licenciamento e Registro de Veiculo) está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCRLV.Focus();
                return false;
            }

            /*if (cliente.Cep.Equals(""))

             {
                 MessageBox.Show("O campo CEP está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtCEP.Focus();
                 return false;
             }*/

            return true;
        }

        private Seguro Recuperar_Informacao_Tela_Seguro()
        {
            Seguro seguro = new Seguro();
            seguro.Modelocarro = cbc_Carro.Text;
            seguro.Placa = txtPlacaCarro.Text;
            seguro.Chassi = txtChassiCarro.Text;
            seguro.Cor = cbc_CorCarro.Text;
            seguro.Ano = txtAnoCarro.Text;
            seguro.Valor = txtValorCarro.Text;
            seguro.Crv = txtCRV.Text;
            seguro.Crlv = txtCRLV.Text;

            return seguro;
        }

        private void btnCancelarSeguros_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    
}   


