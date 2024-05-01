using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoProva_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IMC objIMC = new IMC();

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_altura.Text.Length <= 2)
                    throw new Exception("Altura Incorreta!");                    

                objIMC.Peso = double.Parse(txt_peso.Text.Replace('.',','));
                objIMC.Altura = double.Parse(txt_altura.Text.Replace('.',','));

                MessageBox.Show(objIMC.CalcularIMC());

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Insira apenas números");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
