namespace Exercicio02a06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AppIngresso
    {
        public static void Executar()
        {
            Ingresso ingresso = new Ingresso("Rock Festival", 150.00, 50);

            ingresso.ExibirInformacoes();

            ingresso.AlterarPreco(180.00);
            ingresso.AlterarQuantidade(40);

            ingresso.ExibirInformacoes();

            ingresso.SetNomeDoShow("Pop Music Tour");
            Console.WriteLine($"\nNovo Nome do Show: {ingresso.GetNomeDoShow()}");

            ingresso.SetPreco(200.00);
            Console.WriteLine($"Novo Preço: R$ {ingresso.GetPreco():F2}");

            ingresso.SetQuantidadeDisponivel(30);
            Console.WriteLine($"Nova Quantidade Disponível: {ingresso.GetQuantidadeDisponivel()}");
        }
    }
}