using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        //Declaração de variáveis
        private double num1;
        private double num2;
        private int numConv;
        private double A;
        private double B;
        private double C;


        //Método construtor
        public ModelCalculadora() 
        {
            GetsetNum1 = 0;
            GetsetNum2 = 0;
            GetsetNumConv = 0;
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

        public int GetsetNumConv
        {
            get { return this.numConv; }
            set { this.numConv = value; }
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
            return (- GetsetB) + Math.Sqrt(Delta()) / 2 * GetsetA;
        }//Fim do método X1

        //Método X1
        public double X2()
        {
            return (- GetsetB) - Math.Sqrt(Delta()) / 2 * GetsetA;
        }//Fim do método X2

        public string InverterString(string str)
        {
            int tamanho = str.Length;

            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }

            return new string(caracteres);
            
        }
        public int BinarioParaDecimal(string GetsetNumConv)
        {

            int expoente = 0;

            int numero;

            int soma = 0;

            string numeroInvertido = InverterString(GetsetNumConv);

            for (int i = 0; i < numeroInvertido.Length; i++)
            {

                //pega o dígito por dígito do número digitado

                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));

                //multiplica o dígito por 2 elevado ao expoente, e armazena o resultado em soma

                soma += numero * (int)Math.Pow(2, expoente);

                // incrementa o expoente

                expoente++;

            }

            return soma;

        }

    }// Fim da classe
}// Fim do projeto
