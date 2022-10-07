using Aula1.Entities;
using Aula1.Repositories;

//definindo o namespace ( define a localização da classe no projeto )
namespace Aula01
{
    //declaraçao da Classe
    public class Program
    {
        //Método para execução / iniciliazção do projeto
        public static void Main(string[] args)
        {
            //imprimir mensagem ( console do DOS )
            Console.WriteLine("\n *** Cadastro de Clientes *** \n");

            var cliente = new Cliente();

            try
            {
                Console.WriteLine("\n Digite o nome do cliente");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("\n Digite o email do cliente");
                cliente.Email = Console.ReadLine();
                Console.WriteLine("\n Digite o CPF do Cliente");
                cliente.CPF = Console.ReadLine();
                Console.WriteLine("\n Digite a data de nascimento Cliente");

                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
                cliente.Id = Guid.NewGuid();
                //Pausa o prompt de comandos
                Console.ReadKey();


                Console.WriteLine($"\n Id do Cliente: {cliente.Id}");
                Console.WriteLine($"\n Nome do Cliente: {cliente.Nome}");
                Console.WriteLine($"\n CPF do Cliente: {cliente.CPF}");
                Console.WriteLine($"\n Data de nascimento: {cliente.DataNascimento.ToString("dd/MM/yyyy")}");


                Console.ReadKey();

                ClienteRepository.GravarArquivo(cliente);

            }
            catch (Exception e)
            {

                Console.WriteLine($"Deu merda aqui: {e.Message}");
            }

        }
    }
}