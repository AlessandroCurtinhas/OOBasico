using Projeto03.Entities;
using Projeto03.Repositories;

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

                Console.WriteLine($"\nFalha ao cadastrar o produto ${e.Message}");
            }
        }
        public void AtualizarProduto()
        {
            try
            {
                Console.WriteLine("\nEdição de Produto:\n");
                Console.Write("Informe o ID o produto desejado: ");

                var IdProduto = Guid.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                var produto = produtoRepository.GetById(IdProduto);

                if (produto != null)
                {
                    Console.Write("Nome: ");
                    produto.Nome = Console.ReadLine();
                    Console.Write("Preco: ");
                    produto.Preco = decimal.Parse(Console.ReadLine());
                    Console.Write("Quantidade: ");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    produtoRepository.Update(produto);
                    Console.WriteLine("Produto Atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nProduto não encontrado, verifique o ID informado");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine($"\nFalha ao atualizar o produto: {e.Message}");
            }
        }
        public void ExluirProduto()
        {
            try
            {
                Console.WriteLine("\nEdição de Produto:\n");
                Console.Write("Informe o ID o produto desejado: ");

                var IdProduto = Guid.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                var produto = produtoRepository.GetById(IdProduto);

                if (produto != null)
                {
                    produtoRepository.Delete(produto);
                    Console.WriteLine("Produto Excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nProduto não encontrado, verifique o ID informado");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao excluir o produto: {e.Message}");
            }
        }
        public void ConsultarProdutos()
        {
            try
            {
                Console.WriteLine("\nConsulta de Produtos:\n");

                Console.Write("Entre om o preço mínimo: ");
                var precoMin = decimal.Parse(Console.ReadLine());
                Console.Write("Entre om o preço máximo: ");
                var precoMax = decimal.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                var lista = produtoRepository.GetByPrecos(precoMin, precoMax);

                Console.WriteLine($"\nQuantidade de produtos Obtidos: {lista.Count}\n");

                if(lista.Count != 0 || lista != null)
                {
                    foreach (var item in lista)
                    {
                        Console.WriteLine($"IdProduto: {item.IdProduto}");                        
                        Console.WriteLine($"Nome: {item.Nome}");
                        Console.WriteLine($"Quantidade: {item.Quantidade}");
                        Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
                        Console.WriteLine("-------");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao consultar o produto: {e.Message}");
            }
        }
    }
}
