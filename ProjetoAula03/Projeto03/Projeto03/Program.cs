using Projeto03.Controllers;

public class Program
{
    public static void Main(string[] args)
    {
        var produtoController = new ProdutoController();

        try
        {
            Console.WriteLine("(1) Cadastrar Produto");
            Console.WriteLine("(2) Atualizar Produto");
            Console.WriteLine("(3) Excluir Produto");
            Console.WriteLine("(4) Consultar Produtos");

            Console.Write("\nInforme a opção deseja: ");
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    produtoController.CadastrarProduto();
                    break;
                case 2:
                    produtoController.AtualizarProduto();
                    break;
                case 3:
                    produtoController.ExluirProduto();
                    break;
                case 4:
                    produtoController.ConsultarProdutos();
                    break;
                default:
                    Console.WriteLine("Nenhuma opção válida");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nFalha: {e.Message}");
        }
        finally
        {
            Console.Write("\n Deseja continuar? (S,N): ");
            var opcao = Console.ReadLine();

            if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args);
            }
            else { Console.WriteLine("\nFim do Programa!"); }
        }
    }
}