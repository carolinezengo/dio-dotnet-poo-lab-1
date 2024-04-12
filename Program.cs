

using System.Runtime.CompilerServices;
using DIO.Bank;
using DIO.Bank.Classes;

List<Conta> listContas = new List<Conta>();

string opcaoUsuario = ObterOpcaoUsuario();
while(opcaoUsuario.ToUpper() != "X")
{
  switch(opcaoUsuario)
    {
        case "1":
        ListarContas();
        break;
         case "2":
        InserirConta();
        break;
         case "3":
        Tranferencia();
        break;
         case "4":
        Sacar();
        break;
         case "5":
        Depositar();
        break;
         case "C":
        Console.Clear();
        break;
        default:
        throw new ArgumentOutOfRangeException();
     
    }
    opcaoUsuario=ObterOpcaoUsuario();
 
}


 static string ObterOpcaoUsuario()
{
    Console.WriteLine();
 Console.WriteLine("Dio Bank a seu dispor");
 Console.WriteLine("Informe a opção desejada");

 Console.WriteLine("1- Listar conta ");
 Console.WriteLine("2- Inserir conta");
 Console.WriteLine("3- Transferir");
 Console.WriteLine("4- Sacar");
 Console.WriteLine("5- Depositar");
 Console.WriteLine("C- Limpar Tela ");
 Console.WriteLine("X- Sair ");
 Console.WriteLine();
 string opcaoUsuario = Console.ReadLine().ToUpper();
 Console.WriteLine();
    return opcaoUsuario;
}

void Depositar()
{
    Console.WriteLine("Digite o numero da conta");
    int indiceConta = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor Depositado");
      double valorDeposito = Double.Parse(Console.ReadLine());
  listContas[indiceConta].Depositar(valorDeposito);

}

void  Tranferencia()
{
    Console.WriteLine("Digite o numero da conta origen");
    int indiceContaOrigem = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o numero da conta destino");
    int indiceContaDestino = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor da transferencia");
      double valorTranferencia = Double.Parse(Console.ReadLine());
  listContas[indiceContaOrigem].Transferir(valorTranferencia,listContas[indiceContaDestino]);

}


 void  Sacar()
{
    Console.WriteLine("Digite o numero da conta");
    int indiceConta = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor sacado");
      double valorSque = Double.Parse(Console.ReadLine());
  listContas[indiceConta].Sacar(valorSque);

}

 void InserirConta()
{
    Console.WriteLine("");
      Console.WriteLine("Digite 1 para Conta Fisica ou 2 para Juridica");
      int entradaTipoConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite Nome do Cliente");
         string entradaNomeCliente = Console.ReadLine();

           Console.WriteLine("Digite o saldo Inicial");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o credito");
              double entradaCredito = double.Parse(Console.ReadLine());

          Conta novaConta = new Conta(tipoConta: (TipoConta) entradaTipoConta, 
          saldo:entradaSaldo, 
          credito:entradaCredito,
           nome :entradaNomeCliente); 
        listContas.Add(novaConta);          
}        
 void  ListarContas()
{
     Console.WriteLine("Listar Conta");
     if (listContas.Count == 0)
     {
         Console.WriteLine("Nenhuma conta cadastrada");
         return;
     }else 
     {
        for(int i =0; i < listContas.Count; i++)
        {
            Conta conta = listContas[i];
             Console.Write("# {0}" + 1);
              Console.WriteLine(conta);
        }
     }
    
} 
