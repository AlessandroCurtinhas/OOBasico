using ProjetoAula05.Entities;
using ProjetoAula05.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    public class ClienteRepositoryJSON : IClienteRepository
    {
        public void ExportarDados(Cliente cliente)
        {
            var json = JsonConvert.SerializeObject(cliente, Formatting.Indented);

            using(var streamWriter = new StreamWriter($"c:\\temp\\cliente_{cliente.IdCliente}.json"))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
