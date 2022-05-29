using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguradora
{
    internal class Seguro
    {
        private int id;
        private string modelocarro;
        private string placa;
        private string chassi;
        private string cor;
        private string ano;
        private string valor;
        private string crv;
        private string crlv;


        public int Id { get => id; set => id = value; }
        public string Modelocarro { get => modelocarro; set => modelocarro = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Chassi { get => chassi; set => chassi = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Crv { get => crv; set => crv = value; }
        public string Crlv { get => crlv; set => crlv = value; }
    }
}
