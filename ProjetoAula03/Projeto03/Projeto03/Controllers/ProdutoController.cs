using Projeto03.Entities;
using Projeto03.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Controllers
{
    public class ProdutoController
    {
        public void CadastrarProduto()
        {
            try
            {
                var produto = new Produto();

                Console.WriteLine("\nCadastro de Produto\n");
                Console.Write("Nome: ");
                produto.Nome = Console.ReadLine();
                Console.Write("Preco: ");
                produto.Preco = decimal.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.Create(produto);

                Console.WriteLine("\nProduto salvo com sucesso!\n");

            }
            catch (Exception e)
            {

                Console.WriteLine($"Ocorreu um erro ${e.Message}");
            }
        }

        
    }
}
