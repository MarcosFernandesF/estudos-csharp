using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        //public string nome;
        //public string cpf;
        //public string profissao;

        public string Nome { get; set; } // prop tab tab faz um modelo de propriedade pronto
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        // Método Construtor
        public Cliente()
        {

        }
    }
}