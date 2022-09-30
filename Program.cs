using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

namespace bytebank_ADM 
{
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("ByteBank - ADM");

            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao(); 


            //Funcionario pedro = new Funcionario("151616988", 2000);
            //pedro.Nome = "pedro";
            //Console.WriteLine("Total de funcionario: "+Funcionario.totalFuncionarios);

            //Console.WriteLine("Nome: " + pedro.Nome);
            //Console.WriteLine("CPF: " + pedro.Cpf);
            //Console.WriteLine("Salario: " + pedro.Salario);
            //Console.WriteLine("Bonificacao: " + pedro.GetBonificacao());
            //Console.ReadKey();

            //Diretor paula = new Diretor("15614665", 4300);
            //paula.Nome = "Paula";
            //Console.WriteLine("Total de funcionario: " + Funcionario.totalFuncionarios);

            //Funcionario andre = new Diretor("000000000", 4540);
            //andre.Nome = "Andre";
            //Console.WriteLine("Total de funcionario: " + Funcionario.totalFuncionarios);

            //Console.WriteLine("");

            //Console.WriteLine("Nome: " + paula.Nome);
            //Console.WriteLine("CPF: " + paula.Cpf);
            //Console.WriteLine("Salario: " + paula.Salario);
            //Console.WriteLine("Bonificacao: " + paula.GetBonificacao());
            //Console.WriteLine("");

            //gerenciador.Registrar(pedro);
            //gerenciador.Registrar(paula);

            //Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao);

            //andre.AumentarSalario();
            //Console.WriteLine("Novo salario do andre: " + andre.Salario);

            CalcularBonificacao();

            void CalcularBonificacao() 
            { 
                GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
                Designer pedro = new Designer("833.221.048-35");
                pedro.Nome = "Pedro";

                Diretor paula = new Diretor("344.221.048-35");
                paula.Nome = "paula";

                Auxiliar igor = new Auxiliar("566.221.048-35");
                igor.Nome = "igor";

                GerenteDeContas camila = new GerenteDeContas("882.221.048-35");
                camila.Nome = "camila";

                gerenciador.Registrar(pedro);
                gerenciador.Registrar(paula);
                gerenciador.Registrar(igor);
                gerenciador.Registrar(camila);

                Console.WriteLine("Total de Bonificação: "+gerenciador.getBonificacao);


            }

            Console.ReadKey();
        }
    }
}