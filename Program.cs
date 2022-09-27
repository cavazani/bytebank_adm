using bytebank_ADM.Funcionarios;
namespace bytebank_ADM 
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("ByteBank - ADM");

            Funcionario pedro = new Funcionario();
            pedro.nome = "pedro";
            pedro.cpf = "12135656";
            pedro.salario = 2000;

            Console.WriteLine("Bonificacao: " + pedro.getBonificacao()); 
        }
    }
}