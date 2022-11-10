using bytebank.Contas;
using bytebank.Titular;

//// Instanciando um objeto ContaCorrente em uma variável do tipo ContaCorrente
//ContaCorrente contaDoAndre = new ContaCorrente();
//// É possível acessar os atributos da classe pois são definidos como Publicos
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numeroAgencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numeroAgencia = 15;
//contaDoAndre2.conta = "1010-X";
//contaDoAndre2.saldo = 100;

//contaDoAndre = contaDoAndre2; // contaDoAndre agora aponta para o endereço do contaDoAndre2

//Console.WriteLine(contaDoAndre == contaDoAndre2); //Tipagem por referência, compara endereços de memória

//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numeroAgencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.numeroAgencia);
//Console.WriteLine(contaDoPedro.conta);
//Console.WriteLine(contaDoPedro.saldo);

//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor==valor2); // True, Tipagem por valor, comparando valores
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Nº Conta = " + conta.conta);
//Console.WriteLine("Saldo= " + conta.saldo);
//Console.WriteLine("Nº Agência = " + conta.numeroAgencia);

//// O objeto Cliente tem que ser criado antes de ser alterado, senão terá erro de referência nula.
//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.cpf = "98765321";
//conta2.titular.profissao = "Tester";
//conta2.conta = "9999-X";
//conta2.numeroAgencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

ContaCorrente conta3 = new ContaCorrente();
conta3.NumeroAgencia = 18; // Set com property
conta3.Conta = "1011-H";
conta3.SetSaldo(-10); // Set

Console.WriteLine(conta3.GetSaldo()); // Get
Console.WriteLine(conta3.NumeroAgencia); // Get com property
Console.WriteLine(conta3.Conta);