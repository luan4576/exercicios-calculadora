using System;
namespace byte_bank
{
    public class ContaCorrente
    {
                public int Agencia {get;set;}
                public string Titular {get;set;}
                public int Numeros {get;set;}
                public double Saldo {get;set;}


                public ContaCorrente (int Agencia,string Titular,int Numeros)
                {
                    this.Titular = Titular;
                    this.Agencia = Agencia;
                    this.Numeros = Numeros;
                    this.Saldo = 0.0;
                }
            }
    }

                


    
