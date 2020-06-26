using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>(); 

        public float ValorTotal { get; set; }

        public void Adicionar(Produto _produto){
            carrinho.Add(_produto);
        } 

        public void Alterar(int _codigo, Produto produto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Ler(){
            foreach(Produto item in carrinho){
                System.Console.WriteLine("{0:c} - {1:5}",item.Preco, item.Nome);
            }
        }

        public void Remover(Produto _produto){
            carrinho.Remove(_produto);
        }

        public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("O valor total da compra é {0:c}",ValorTotal);
            Console.ResetColor();

        }
    }
}