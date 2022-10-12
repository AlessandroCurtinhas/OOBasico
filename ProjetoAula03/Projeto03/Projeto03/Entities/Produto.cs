namespace Projeto03.Entities
{
    public class Produto
    {
        #region Propriedades
        public Guid IdProduto { get; set; }
        public String Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastri { get; set; }

        #endregion


    }
}
