using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        //Método Construtor
        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//Fim do método construtor

        //Método Coletar
        public void Coletar()
        {
            Console.WriteLine("Informe um número");
            this.calculadora.GetsetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número");
            this.calculadora.GetsetNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método coletar

        //Método Coleta
        public void Coleta()
        {
            Console.WriteLine("Informe um número");
            this.calculadora.GetsetNumConv = Convert.ToInt32(Console.ReadLine());

        }//Fim do método coleta

        //Método Coletar
        public void ColetaBhaskara()
        {
            Console.WriteLine("Informe o A");
            this.calculadora.GetsetA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o B");
            this.calculadora.GetsetB = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe o C");
            this.calculadora.GetsetC = Convert.ToDouble(Console.ReadLine());
        }//Fim do método coleta A, B e C

        //Método Menu
        public int Menu()
        {
            Console.WriteLine("-------------- Menu --------------" +
                              "\n0. Sair"                          +
                              "\n1. Somar"                         +
                              "\n2. Subtrair"                      +
                              "\n3. Multiplicar"                   +
                              "\n4. Dividir"                       +
                              "\n5. Potência"                      +
                              "\n6. Raiz do primeiro número"       +
                              "\n7. Tabuada"                       +
                              "\n8. Binário para Decmal"           +
                              "\n9. Decimal para Binário"          +
                              "\n10. Decimal para Hexadecimal"     +
                              "\n11. Hexadecimal para Decimal"     +
                              "\n12. Bhaskara"                     +
                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do método menu

        //Método Operação
        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        Console.ReadLine();
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        Console.WriteLine("Multiplicação: " + this.calculadora.Multiplicar());
                        break;
                    case 4:
                        Coletar();
                        if (this.calculadora.Divisao() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisao: " + this.calculadora.Divisao());
                        }
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetsetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Coleta();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 9:
                        Coleta();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 10:
                        Coleta();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 11:
                        Coleta();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 12:
                        ColetaBhaskara();
                        Console.WriteLine("Delta: " + this.calculadora.Delta());
                        Console.WriteLine("X1: " + this.calculadora.X1());
                        Console.WriteLine("X2: " + this.calculadora.X2());
                        break;
                }//Fim do switch
            } while (opcao != 0);//fim do Do...While
        }//Fim do método operacao
    }//Fim da Classe
}//Fim do projeto
