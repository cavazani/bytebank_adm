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

            Console.WriteLine("Bonificacao: " + pedro.getBonificacao()); 
        }
    }
}