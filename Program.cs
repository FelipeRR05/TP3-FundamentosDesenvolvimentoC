using System;
using Exercicio01;
using Exercicio02a06;
using Exercicio07a09;
using Exercicio10a12;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Escolha um Exercício para Executar ===");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2 a 6");
            Console.WriteLine("3 - Exercício 7 a 9");
            Console.WriteLine("4 - Exercício 10 a 12");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite a opção desejada: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Aluno.Executar();
                    break;
                case "2":
                    AppIngresso.Executar();
                    break;
                case "3":
                    TestaMatricula.Executar();
                    break;
                case "4":
                    TestaFiguras.Executar();
                    break;
                case "0":
                    Console.WriteLine("\nSaindo do programa...");
                    return;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}