using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

namespace bytebank_ADM 
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("ByteBank - ADM");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao(); 


            Funcionario pedro = new Funcionario("151616988");
            pedro.Nome = "pedro";
            pedro.Salario = 2000;
            Console.WriteLine("Total de funcionario: "+Funcionario.totalFuncionarios);

            Console.WriteLine("Nome: " + pedro.Nome);
            Console.WriteLine("CPF: " + pedro.Cpf);
            Console.WriteLine("Salario: " + pedro.Salario);
            Console.WriteLine("Bonificacao: " + pedro.GetBonificacao());
            Console.ReadKey();

            Diretor paula = new Diretor("15614665");
            paula.Nome = "Paula";
            paula.Salario = 5000;
            Console.WriteLine("Total de funcionario: " + Funcionario.totalFuncionarios);

            Funcionario andre = new Diretor("000000000");
            andre.Nome = "Andre";
            Console.WriteLine("Total de funcionario: " + Funcionario.totalFuncionarios);

            Console.WriteLine("");

            Console.WriteLine("Nome: " + paula.Nome);
            Console.WriteLine("CPF: " + paula.Cpf);
            Console.WriteLine("Salario: " + paula.Salario);
            Console.WriteLine("Bonificacao: " + paula.GetBonificacao());
            Console.WriteLine("");

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(paula);

            Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao);

            Console.ReadKey();
        }
    }
}