using bytebank_ADM.Funcionarios;
namespace bytebank_ADM 
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("ByteBank - ADM");

            Funcionario pedro = new Funcionario();
            pedro.Nome = "pedro";
            pedro.Cpf = "12135656";
            pedro.Salario = 2000;

            Console.WriteLine("Nome: " + pedro.Nome);
            Console.WriteLine("CPF: " + pedro.Cpf);
            Console.WriteLine("Salario: " + pedro.Salario);

            Console.WriteLine("Bonificacao: " + pedro.getBonificacao());
            Console.ReadKey();

            Diretor paula = new Diretor();
            paula.Nome = "Paula";
            paula.Cpf = "12135656";
            paula.Salario = 5000;

            Console.WriteLine("Nome: " + paula.Nome);
            Console.WriteLine("CPF: " + paula.Cpf);
            Console.WriteLine("Salario: " + paula.Salario);

            Console.WriteLine("Bonificacao: " + paula.getBonificacao());
            Console.ReadKey();
        }
    }
}