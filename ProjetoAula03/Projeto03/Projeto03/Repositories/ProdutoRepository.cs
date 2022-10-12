using Dapper;
using Projeto03.Configurations;
using Projeto03.Entities;
using System.Data.SqlClient;

namespace Projeto03.Repositories
{
    public class ProdutoRepository
    {
        public void Create(Produto produto)
        {

            var query = @"INSERT INTO PRODUTO VALUES ( NEWID(), @Nome, @Preco, @Quantidade, GETDATE())";

            using (var connecion = new SqlConnection(SqlServerConfiguration.GetConneciontString()))
            {

                connecion.Execute(query, produto);
            }
        }
        public void Update(Produto produto) { }
        public void Delete(Produto produto) { }
        public List<Produto> GetAll() 
        { 
            return new List<Produto>(); 
        }   
        public Produto GetById(Guid idProduto)
        {
            return new Produto();
        }
    }
}
