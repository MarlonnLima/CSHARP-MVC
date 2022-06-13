using System;
using System.Windows.Forms;

    public class CalculadorDeIMC
    {
        /*
        Declaração das variáveis de instância

        */
        private double altura;
        private double peso;

        public string CalculaIMC()
        {    
            double resultadoIMC;
            resultadoIMC = peso / (altura * altura);

            return Convert.ToString(resultadoIMC);     
        }


        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        public double GetAltura()
        {
            return altura;
        }


        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public double GetPeso()
        {
            return peso;
        }

    }
