namespace Exercicio02a06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Ingresso
    {
        private string nomeDoShow;
        private double preco;
        private int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public string GetNomeDoShow() => nomeDoShow;
        public double GetPreco() => preco;
        public int GetQuantidadeDisponivel() => quantidadeDisponivel;

        public void SetNomeDoShow(string novoNome) => nomeDoShow = novoNome;
        public void SetPreco(double novoPreco) => preco = novoPreco;
        public void SetQuantidadeDisponivel(int novaQtd) => quantidadeDisponivel = novaQtd;

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
            Console.WriteLine($"\nPreço atualizado para R$ {preco:F2}");
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
            Console.WriteLine($"Quantidade de ingressos disponível agora é {quantidadeDisponivel}");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nShow: {nomeDoShow}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
            Console.WriteLine($"Ingressos Disponíveis: {quantidadeDisponivel}");
        }
    }
}