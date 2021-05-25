using System;

namespace DIO.bank
{
    public class Conta
    {

        private TipoConta TipoConta {get; set;}

        private double Saldo {get; set;}

        private double Credito {get; set;}

        private string nome {get; set;}  

    public Conta(TipoConta tipoConta, double saldo, double credito, string nome){

        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Credito = credito;
        this.nome = nome;


    }

    public bool Sacar(double valorSaque){

        if(this.Saldo - valorSaque < (this.Credito *-1) ){

            Console.WriteLine("Saldo insuficiente!");
            return false;

        }

        this.Saldo -= valorSaque;

        Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.Saldo);

        return true;
    }   

    public void Depositar (double valorDeposito){

        this.Saldo += valorDeposito;

        Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.Saldo);

    }

    public void Transferir (double valorTransferencia, Conta contaDestino) {

        if(this.Sacar(valorTransferencia)){

            contaDestino.Depositar(valorTransferencia);

        }

    }

        public override string ToString(){

            string retorno = "";
            retorno += "Tipo Conta: " + this.TipoConta + " | ";
            retorno += "Nome:  " + this.nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Tipo Crédito: " + this.Credito;
            return retorno;

        }

        
    }

   
}