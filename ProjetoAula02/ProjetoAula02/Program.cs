using ProjetoAula02.Controller;

namespace ProjetoAula02
{
    public class Program
    {
        public static void Main (string[] args)
        {
            var funcionarioController = new FuncionarioController();
            funcionarioController.CadastrarFuncionario();

        }
    }
}