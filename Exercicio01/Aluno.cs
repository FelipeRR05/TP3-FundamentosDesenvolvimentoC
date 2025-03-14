namespace Exercicio01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];

        public double CalcularMedia()
        {
            return Notas.Average();
        }

        public string VerificarAprovacao()
        {
            double media = CalcularMedia();
            return media >= 7 ? "Aprovado" : "Reprovado";
        }

        public static void Executar()
        {
            Aluno aluno = new Aluno
            {
                Nome = "Felipe Roberto Rocha",
                Notas = new double[] { 6.5, 8.0, 7.0 }
            };

            double mediaFinal = aluno.CalcularMedia();
            string resultado = aluno.VerificarAprovacao();

            Console.WriteLine($"\nNome: {aluno.Nome}");
            Console.WriteLine($"Notas: {string.Join(", ", aluno.Notas)}");
            Console.WriteLine($"Média Final: {mediaFinal:F2}");
            Console.WriteLine($"Situação: {resultado}");
        }
    }
}