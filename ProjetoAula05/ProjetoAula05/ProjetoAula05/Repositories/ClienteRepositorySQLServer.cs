using Dapper;
using ProjetoAula05.Entities;
using ProjetoAula05.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    public class ClienteRepositorySQLServer : IClienteRepository
    {
        public void ExportarDados(Cliente cliente)
        {
            var query = @"
                INSERT INTO CLIENTE(IDCLIENTE, NOME, CPF, EMAIL)
                VALUES
                (@IdCliente,@Nome,@Cpf,@Email)
            ";

            using(var conncection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBExAula03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conncection.Execute(query, cliente);
            }

        }
    }
}
