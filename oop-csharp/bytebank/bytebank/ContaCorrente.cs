using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numeroAgencia;
        public double saldo;

        // Método público e que não retorna nada (Void)
        public void Depositar(double valor)
        {
            // This representa o próprio objeto, é como se fosse um self do python
            this.saldo += valor;
        }

        // Método público que retorna um valor booleano (True or False)
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
