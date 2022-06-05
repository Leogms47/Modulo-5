using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos_Estoques
{
    class Produto
    {
        //Auto Propidades
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtores
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
        }
      
    }
}
