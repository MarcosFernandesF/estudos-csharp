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
        private int numeroAgencia; // Int Valor padrão = 0
        public int NumeroAgencia // O property por padrão é public e tem a primeira palavra capitalizada
        {
            get { return numeroAgencia; }
            set
            {
                if (value > 0)
                {
                    this.numeroAgencia = value;
                }
            }
        }

        //private string conta; // String Valor padrão = Vazio

        // Propriedade autoimplementada, Muito útil para quando não precisa de validação em setter.
        // Internamente o C# cria uma variável private conta. 
        public string Conta { get; set; } 

        private double saldo = 100; // Double Valor padrão = 0

        public Cliente Titular { get; set; }; // Composição: titular vai receber uma classe instanciada fora de ContaCorrente

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
        // Setter
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return; // Return para a execução do método
            }
            else
            {
                this.saldo = valor;
            }
        }
        //Getter
        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
