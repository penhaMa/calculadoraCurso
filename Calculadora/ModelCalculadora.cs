using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        //Declaração de variáveis
        private double num1;
        private double num2;
        private double A;
        private double B;
        private double C;


        //Método construtor
        public ModelCalculadora() 
        {
            GetsetNum1 = 0;
            GetsetNum2 = 0;
            GetsetA = 0;
            GetsetB = 0;
            GetsetC = 0;
        }// Fim do método construtor   


        //Métodos Gets e Sets
        public double GetsetNum1
        { 
            get { return this.num1; }
            set { this.num1 = value; }
        }//Fim do GetSetNum1

        public double GetsetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//Fim do GetSetNum2

        public double GetsetA
        {
            get { return this.A; }
            set { this.A = value; }
        }//Fim do GetSetNum2

        public double GetsetB
        {
            get { return this.B; }
            set { this.B = value; }
        }//Fim do GetSetNum2

        public double GetsetC
        {
            get { return this.C; }
            set { this.C = value; }
        }//Fim do GetSetNum2

        //Fim dos Métodos Get e Set


        //Métodos

        //Método Somar
        public double Somar()
        {
            return GetsetNum1 + GetsetNum2;
        }//Fim do método Somar

        //Método Subtrair
        public double Subtrair()
        {
            return GetsetNum1 - GetsetNum2;
        }//Fim do método Subtrair

        //Método Multiplicar
        public double Multiplicar()
        {
            return GetsetNum1 * GetsetNum2;
        }//Fim do método Multiplicar

        //Método Divisao
        public double Divisao()
        {
            if (GetsetNum2 <= 0)
            {
                return -1;
            }    
            else
            {
                return GetsetNum1 / GetsetNum2;
            }//Fim do if e else  
        }//Fim do método Divisao

        //Método Potencia
        public double Potencia()
        {
            return Math.Pow(GetsetNum1, GetsetNum2);
        }//Fim do método Potencia

        //Método Raiz
        public string Raiz()
        {
            string msg = "Raiz do primeiro número: " + Math.Sqrt(GetsetNum1) +
                         "\nRaiz do segundo número: " + Math.Sqrt(GetsetNum2);
            return msg;
        }//Fim do método Raiz

        //Método Tabuada 
        public string TabuadaNum1()
        {
            string resultado =  "";
            
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetsetNum1 + " * " + i + " = " + (GetsetNum1 * i); 
            }//Fim do For

            return resultado;
        }//Fim do método Tabuada 

        //Método Delta
        public double Delta()
        {
            return (GetsetB * GetsetB) - (4) * (GetsetA * GetsetC);
        }//Fim do método Delta

        //Método X1
        public double X1()
        {
            if (Delta() <= 0)
            {
                return -1;
            }
            else
            {
                return (-GetsetB + Math.Sqrt(Delta())) / (2 * GetsetA);
            }
        }//Fim do método X1

        //Método X2
        public double X2()
        {
            return (-GetsetB - Math.Sqrt(Delta())) / (2 * GetsetA);
        }//Fim do método X2

        //Método binario para decimal
        public static int BinarioParaDecimal(string numeroBinario)
        {
            int expoente = 0;
            int numero;
            int soma = 0;
            string numeroInvertido = ReverteString(numeroBinario);
            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }
            return soma;
        }//fim do método binario para decimal

        //Método decimal para binario
        public static string DecimalParaBinario(string numeroDecimal)
        {
            string valor1 = "";
            int dividendo = Convert.ToInt32(numeroDecimal);
            if (dividendo == 0 || dividendo == 1)
            {
                return Convert.ToString(dividendo);
            }
            else
            {
                while (dividendo > 0)
                {
                    valor1 += Convert.ToString(dividendo % 2);
                    dividendo = dividendo / 2;
                }
                return ReverteString(valor1);
            }
        }//fim do método decimal para binario

        //Método decimal para hexadecimal
        public static string DecimalParaHexadecimal(string numeroDecimal)
        {
            string valor2 = "";
            int dividendo = Convert.ToInt32(numeroDecimal);
            if (dividendo == 0 || dividendo == 1)
            {
                return Convert.ToString(dividendo);
            }
            else
            {
                while (dividendo > 0)
                {
                    valor2 += Convert.ToString(dividendo % 16);
                    dividendo = dividendo / 16;
                }
                return ReverteString(valor2);
            }

            int op = 0;
            switch (op)
            {
                case 1:
                valor2 = "10";
                    break;
                   
            }
        }//fim do método decimal para hexadecimal

        //Método hexadecimal para decimal
        public static long HexadecimalParaDecimal(string numeroHexadecimal)
        {
            long resultado = 0;
            int comprimento = numeroHexadecimal.Length;

            for (int i = 0; i < comprimento; i++)
            {
                char caractere = numeroHexadecimal[i];
                int valor;

                if (caractere >= '0' && caractere <= '9')
                {
                    valor = caractere - '0';
                }
                else if (caractere >= 'A' && caractere <= 'F')
                {
                    valor = caractere - 'A' + 10;
                }
                else if (caractere >= 'a' && caractere <= 'f')
                {
                    valor = caractere - 'a' + 10;
                }
                else
                {
                    throw new ArgumentException("O valor hexadecimal contém caracteres inválidos.");
                }

                int expoente = comprimento - i - 1;
                resultado += valor * (1L << (expoente * 4));
            }

            return resultado;
        }//fim do método hexadecimal para decimal

        //Método revert 
        public static string ReverteString(string str)
        {
            return new string(str.Reverse().ToArray());
        }//fim do método reverte string

    }// Fim da classe
}// Fim do projeto
