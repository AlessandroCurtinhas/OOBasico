using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Repositories
{
    public class FuncionarioRepositoryTxt : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo o nome e local do path

            var path = "C:\\temp\\funcionario.txt";


            #endregion

            #region Gravando o conteudo do arquivo           

            using (var stream = new StreamWriter(path,true))
            {

                stream.WriteLine($"Id do funcionario: {funcionario.Id}");
                stream.WriteLine($"Nome: {funcionario.Nome}");
                stream.WriteLine($"CPF:  {funcionario.Cpf}");
                stream.WriteLine($"Data de Nascimento:  {funcionario.DataNascimento.ToString("dd/MM/yyyy")}");
                stream.WriteLine($"Matricula:  {funcionario.Matricula}");
                stream.WriteLine($"Data de Admissão:  {funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");
                stream.WriteLine($"Id do setor: {funcionario.Setor.Id}");
                stream.WriteLine($"Setor do funcionario:  {funcionario.Setor.Sigla}");
                stream.WriteLine($"Descrição do Setor:  {funcionario.Setor.Descricao}\n");
             
            }

            #endregion
        }

       
    }
}
