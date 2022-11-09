using bytebank;

// Instanciando um objeto ContaCorrente em uma variável do tipo ContaCorrente
ContaCorrente contaDoAndre = new ContaCorrente();
// É possível acessar os atributos da classe pois são definidos como Publicos
contaDoAndre.titular = "André Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);