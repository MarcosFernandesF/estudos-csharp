using bytebank;

// Instanciando um objeto ContaCorrente em uma variável do tipo ContaCorrente
ContaCorrente contaDoAndre = new ContaCorrente();
// É possível acessar os atributos da classe pois são definidos como Publicos
contaDoAndre.titular = "André Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

ContaCorrente contaDoAndre2 = new ContaCorrente();
contaDoAndre2.titular = "André Silva";
contaDoAndre2.numeroAgencia = 15;
contaDoAndre2.conta = "1010-X";
contaDoAndre2.saldo = 100;

contaDoAndre = contaDoAndre2; // Igualando os endereços

Console.WriteLine(contaDoAndre == contaDoAndre2); //Tipagem por referência, compara endereços de memória

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



