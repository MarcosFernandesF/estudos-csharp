using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public string conta; // String Valor padrão = Vazio
        public int numeroAgencia; // Int Valor padrão = 0
        public double saldo = 100; // Double Valor padrão = 0

        public Cliente titular; // Composição: titular vai receber uma classe instanciada fora de ContaCorrente

        // Método público e que não retorna nada (Void)
        public void Depositar(double valor)
        {
            // This representa o próprio objeto, é como se fosse um self do python
            saldo += valor;
        }

        // Método público que retorna um valor booleano (True or False)
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
