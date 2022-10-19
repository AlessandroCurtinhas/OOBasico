using ProjetoAula05.Entities;
using ProjetoAula05.Interfaces;
using ProjetoAula05.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Controllers
{
    public class ClienteController
    {
        public void CadastrarCliente()
        {
            try
            {
                Console.WriteLine("\nCadastro de Cliente\n");

                var cliente = new Cliente();
                cliente.IdCliente = Guid.NewGuid();

                Console.Write("Nome do cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.Write("CPF do cliente: ");
                cliente.Cpf = Console.ReadLine();
                Console.Write("Email do Cliente: ");
                cliente.Email = Console.ReadLine();

                Console.Write("Informe (1)JSON ou (2)SQLSERVER: ");
                var opcao = int.Parse(Console.ReadLine());

                IClienteRepository clienteRepository = null;

                switch(opcao)
                {
                    case 1:
                        clienteRepository = new ClienteRepositoryJSON();
                        break;
                    case 2:
                        clienteRepository = new ClienteRepositorySQLServer();
                        break;
                    default:
                        throw new Exception("Nenhuma opção válida");
                        break;
                }

                clienteRepository.ExportarDados(cliente);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"\nErro de validação: {e.Message}");
                
            }catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar o cliente");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nDeseja continuar? (S,N)...:");
                var opcao = Console.ReadLine();

                if(opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    CadastrarCliente();
                }
                
            }
            Console.WriteLine("\nFim do Programa!");
        }
    }
}
