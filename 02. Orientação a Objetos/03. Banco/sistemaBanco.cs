using System;
using TItular;

namespace bancoSistema
{
    public class Banco
    {
        
        // Criando um get e set para Conta e TotalDeContasCriadas (propriedade)
        public string? Conta { get; set; }
        public static int TotalDeContasCriadas { get; private set; }


        public Cliente? Titular { get; set; }


        // Criando um get e set para numero_agencia (propriedade implementadas)
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }

            private set {
                    if (value > 0)
                    {
                        this.numero_agencia = value;
                    }
            }
        }


        // Criando um get e set para saldo (propriedade implementadas)
        private double saldo = 100;
        public double Saldo
        {
            get { return this.saldo; }
            set {  
                    if (value < 0)
                    {
                        return;
                    } 
                    else 
                    {
                        saldo = value;
                    }
                }
        }


        // Função de Depositar um valor na conta
        public void Depositar(int valor)
        {
            this.saldo += valor;
        }


        // Função de Sacar um valor, exeto valores acima do contido na conta
        public bool Sacar(int valor)
        {
            if (valor <= this.saldo) 
            {
                this.saldo -= valor;
                return true;

            } else {
                return false;
            }
        }


        // Função de Transferir valor para outra conta
        public bool Transferir(int valor, Banco contaRecorente)
        {
            if (this.saldo < valor)
            {
                return false;

            } else {
                Sacar(valor);
                contaRecorente.Depositar(valor);
                return true;
            }
        }


        // Membro estático da classe, requerendo determinar o 
        // numero da conta e da agencia na criação de uma conta
        public Banco(int numero_agencia, string numero_conta) {
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }
    }
}