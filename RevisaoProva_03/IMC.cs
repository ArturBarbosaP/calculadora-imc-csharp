using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProva_03
{
    internal class IMC
    {
        private double altura, peso;

        public double Altura
        {
            get => altura;
            set
            {
                if (value >= 1)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura mínima deve ser de 1.00 metro.");
                }
            }
        }

        public double Peso 
        {
            get => peso;
            set
            {
                if (value >= 1)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso não poderá ser 0 kg.");
                }
            } 
        }

        public string CalcularIMC()
        {
            double imc = peso / Math.Pow(altura, 2);

            if (imc >= 40)
            {
                return "IMC: " + imc.ToString("0.00") + "\nObesidade grau III";
            }
            else if (imc >= 35)
            {
                return "IMC: " + imc.ToString("0.00") + "\nObesidade grau II";
            }
            else if (imc >= 30)
            {
                return "IMC: " + imc.ToString("0.00") + "\nObesidade grau I";
            }
            else if (imc >= 25)
            {
                return "IMC: " + imc.ToString("0.00") + "\nVocê está acima do seu peso ideal (sobrepeso)";
            }
            else if (imc >= 18.5)
            {
                return "IMC: " + imc.ToString("0.00") + "\nParabéns, você está em seu peso ideal!";
            }
            else
            {
                return "IMC: " + imc.ToString("0.00") + "\nVocê está abaixo do peso ideal!";
            }
        }
    }
}
