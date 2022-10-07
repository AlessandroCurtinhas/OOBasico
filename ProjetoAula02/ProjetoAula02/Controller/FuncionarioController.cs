using ProjetoAula02.Entities;
using ProjetoAula02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula02.Controller
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n Cadastro de Funcionario \n");

                #region Capturar os dados funcionarios
                var funcionario = new Funcionario();

                funcionario.Id = Guid.NewGuid();
                Console.Write("Nome do funcionario: ");
                funcionario.Nome = Console.ReadLine();
                Console.Write("Matricula: ");
                funcionario.Matricula = Console.ReadLine();
                Console.Write("CPF: ");
                funcionario.Cpf = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de admissão: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                #endregion

                #region Capturar dados do setor

                funcionario.Setor = new Setor();
                funcionario.Setor.Id = Guid.NewGuid();
                Console.Write("Digite a Sigla do Setor: ");
                funcionario.Setor.Sigla = Console.ReadLine();
                Console.Write("Digite a descrição: ");
                funcionario.Setor.Descricao = Console.ReadLine();

                #endregion

                #region Exportando os dados para arquivo

                Console.Write("\n Informe (1)CSV ou (2)TXT: ");
                var opcao = int.Parse(Console.ReadLine());

                FuncionarioRepository funcionarioRepository = null;

                switch (opcao)
                {                 
                    case 1:
                        funcionarioRepository = new FuncionarioRepositoryCsv();                      
                        break;

                    case 2:
                        
                        funcionarioRepository = new FuncionarioRepositoryTxt();                   
                        break;
                    
                    default:
                        Console.WriteLine("Formato inválido");
                        break;
                }

                if(funcionarioRepository != null)
                {
                    funcionarioRepository.ExportarDados(funcionario);
                    Console.WriteLine("\n Dados Gravados com sucesso!");
                }

                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n Falha ao Cadastrar: {e.Message} ");           
            }
        }
    }
}
