using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Repositories
{
    public class FuncionarioRepositoryCsv : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Path

            var path = "C:\\temp\\funcionario.csv";

            #endregion

            #region Gravando dados

            using (var stream = new StreamWriter(path, true))
            {
                var texto = $"{funcionario.Id};"
                 + $"{funcionario.Nome};"
                 + $"{funcionario.Cpf};"
                 + $"{funcionario.DataNascimento.ToString("dd/MM/yyyy")};"
                 + $"{funcionario.Matricula};"
                 + $"{funcionario.DataAdmissao.ToString("dd/MM/yyyy")};"
                 + $"{funcionario.Setor.Id};"
                 + $"{funcionario.Setor.Sigla};"
                 + $"{funcionario.Setor.Descricao};";

                stream.WriteLine(texto);
            }

            #endregion

        }
    }
}
