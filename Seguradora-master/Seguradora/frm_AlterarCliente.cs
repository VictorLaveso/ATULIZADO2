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
    public partial class frm_AlterarCliente : Form
    {
        public frm_AlterarCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Recuperar_Informacao_Tela();
            //validar cliente
            bool v = validar_cliente(cliente);
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
        private Cliente Recuperar_Informacao_Tela()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = cbcNome.Text;
            cliente.Cpf = txtCPF.Text;
            cliente.Sexo = cbcSexo.Text;
            cliente.Telefonefixo = txtTelFixo.Text;
            cliente.Telefonecelular = txtTelCelular.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numerocasa = txtNEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Cep = txtCEP.Text;


            return cliente;
        }
        private bool validar_cliente(Cliente cliente)
        {
            if (cliente.Nome.Equals(""))
            {
                MessageBox.Show("O campo nome está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcNome.Focus();
                return false;
            }
            if (cliente.Cpf.Equals(""))
            {
                MessageBox.Show("O campo CPF está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
                return false;
            }
            if (cliente.Sexo.Equals(""))
            {
                MessageBox.Show("O campo sexo está em braco !! \nEscolha uma opção !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcSexo.Focus();
                return false;
            }
            if (cliente.Telefonecelular.Equals(""))

            {
                MessageBox.Show("O campo Celular está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelCelular.Focus();
                return false;
            }
            if (cliente.Endereco.Equals(""))
            {
                MessageBox.Show("O campo Endereço está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return false;
            }

            if (cliente.Numerocasa.Equals(""))

            {
                MessageBox.Show("O campo Numero da Casa está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNEndereco.Focus();
                return false;
            }

            if (cliente.Bairro.Equals(""))

            {
                MessageBox.Show("O campo Bairro está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if (cliente.Cidade.Equals(""))

            {
                MessageBox.Show("O campo Cidade está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
                return false;
            }

            if (cliente.Cep.Equals(""))

            {
                MessageBox.Show("O campo CEP está em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCEP.Focus();
                return false;
            }

            return true;
        }
    }
}
