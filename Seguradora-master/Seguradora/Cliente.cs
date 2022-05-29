using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguradora
{

    public class Cliente
    {

        private int id;
        private string nome;
        private string cpf;
        private string sexo;
        private string telefonefixo;
        private string telefonecelular;
        private string email;
        private string endereco;
        private string numerocasa;
        private string bairro;
        private string cidade;
        private string cep;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefonefixo { get => telefonefixo; set => telefonefixo = value; }
        public string Telefonecelular { get => telefonecelular; set => telefonecelular = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numerocasa { get => numerocasa; set => numerocasa = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
