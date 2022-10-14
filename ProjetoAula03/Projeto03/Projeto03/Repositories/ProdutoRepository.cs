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

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConneciontString()))
            {

                connection.Execute(query, produto);
            }
        }
        public void Update(Produto produto)
        {
            var query = @"UPDATE PRODUTO SET
                            Nome = @Nome,
                            Preco = @Preco,
                            Quantidade = @Quantidade    
                        WHERE IDPRODUTO = @IdProduto
                        ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConneciontString()))
            {
                connection.Execute(query, produto);
            }
        }
        public void Delete(Produto produto)
        {
            var query = @"DELETE FROM PRODUTO WHERE IDPRODUTO = @IdProduto";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConneciontString()))
            {
                connection.Execute(query, produto);
            }
        }
        public List<Produto>? GetAll()
        {
            var query = @"SELECT * FROM PRODUTO ORDER BY NOME";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConneciontString()))
            {
                return connection.Query<Produto>(query).ToList();
            }
        }
        public List<Produto>? GetByPrecos(decimal precoMin, decimal precoMax)
        {
            var query = @"SELECT * FROM PRODUTO WHERE PRECO BETWEEN @precoMin and @precoMax ORDER BY PRECO DESC";

            using(var connection = new SqlConnection(SqlServerConfiguration.GetConneciontString()))
            {
                return connection.Query<Produto>(query, new { precoMin, precoMax}).ToList();
            }
        }
        public Produto? GetById(Guid idProduto)
        {
            var query = @"SELECT * FROM PRODUTO WHERE IDPRODUTO = @IdProduto";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConneciontString()))
            {
                return connection.Query<Produto>(query, new { idProduto }).FirstOrDefault();
            }
        }
    }
}
