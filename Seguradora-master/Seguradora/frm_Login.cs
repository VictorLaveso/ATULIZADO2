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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "victor" || txtSenha.Text == "victorfernando")
            {
                Seguros seguros = new Seguros();
                seguros.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou Senha esta ERRADO !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Clear();
                txtSenha.Clear();

            }

            POSTGRESQL.CConexao objetoConexao = new POSTGRESQL.CConexao();
            objetoConexao.estabelecerConexao();

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
