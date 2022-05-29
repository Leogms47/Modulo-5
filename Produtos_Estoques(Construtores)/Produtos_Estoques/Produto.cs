using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos_Estoques
{
    class Produto
    {
        //Atributos da Classe
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtores
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Este método retornar a multiplicação do preço x quantidade
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Este método retornar a formatação de string concatenados com seus respectivos valores
        public override string ToString()
        {
            return "Produto: " + Nome + ", Preço: R$ " + Preco.ToString("F2") + ", Quantidade: " + Quantidade + ", Total: R$ " + ValorTotalEmEstoque().ToString("F2");
        }

        //Este método faz com que o atributo Quantidade recebe ela mesma + quantidade que é o parâmetro de entrada
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        //Este método faz com que o atributo Quantidade recebe ela mesma - quantidade que é o parâmetro de entrada
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
    }
}
