using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO.Bank.Classes;

namespace DIO.Bank
{
    public class Conta
    {
        public TipoConta TipoConta { get; set; }
        public double Saldo { get; set; }
        public double Credito { get; set; }
        public string Nome { get; set; }
        
 

    public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
    {
        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;

    }

    public bool Sacar(double valorSque)
    {
        if(this.Saldo - valorSque < (this.Credito *-1))
        {
            Console.WriteLine("Saldo Insuficiante");
            return false;
        } else{

            this.Saldo = Saldo - valorSque;
             Console.WriteLine("Saque efetuado com sucesso. Valor do saldo Atual é: " + this.Nome + this.Saldo);
         return true;

    }
    }
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta:" + this.TipoConta;
            retorno += " Nome:" + this.Nome;
            retorno += " Saldo:" +this.Saldo;
            retorno += " Credito:" + this.Credito;
            return retorno;

        }

       
public void Depositar(double valorDeposito)
{
    this.Saldo += valorDeposito;
      Console.WriteLine("Deposito efetuado com sucesso. Valor do saldo Atual é: " +this.Saldo)
;
}
   public void Transferir(double valorTranferencia, Conta contaDestino)
    {
        if(this.Sacar( valorTranferencia))
        {
            contaDestino.Depositar(valorTranferencia);
        
            
        } 


}
}
}