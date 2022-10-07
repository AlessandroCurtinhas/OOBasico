using Aula1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Repositories
{
    public class ClienteRepository
    {
        public static void GravarArquivo(Cliente cliente)
        {
            
            var path = $"C:\\temp\\cliente_{cliente.Id}.txt";

            var streamWriter = new StreamWriter(path);
            streamWriter.WriteLine($"ID  {cliente.Id}");
            streamWriter.WriteLine($"Nome  {cliente.Nome}");
            streamWriter.WriteLine($"CPF  {cliente.CPF}");
            streamWriter.WriteLine($"Email  {cliente.Email}");
            streamWriter.WriteLine($"Data de Nascimento  {cliente.DataNascimento}");

            streamWriter.Flush();
            streamWriter.Close();

        }
    }
}
