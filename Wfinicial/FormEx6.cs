using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfinicial
{
    public partial class FormsEx6 : Form
    {
        public FormsEx6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Faça um formulário que solicite o nome do usuário,
            //o quanto ganha por hora e o número de horas trabalhadas no mês.
            //Calcule o resultado e mostre o nome e o total da renda recebida no mês.

            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("\nInforme o numero de horas trabalhadas: ");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double resultado = valorHora * quantidadeHoras;

            Console.WriteLine($"A renda total de {nome} é R$ {resultado:F2}");


        }
    }
}
