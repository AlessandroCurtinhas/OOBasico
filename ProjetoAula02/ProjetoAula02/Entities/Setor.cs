using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Entities
{
    public class Setor
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        #endregion

        #region Associações
        public IList<Funcionario> Funcionarios { get; set; }
        #endregion
    }
}
