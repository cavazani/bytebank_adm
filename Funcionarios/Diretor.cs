using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios {
    public class Diretor: Funcionario //Herança: estou informando que a classe diretor tem as proprioedades de funcionario
    {
        //Override, refinindo o metodo da classe pai
        public override double GetBonificacao() {
            return Salario + 0.5; //Base é usado para confirmar que esta sendo usado o metodo da classe pai
        }

        //Construtor
        public Diretor(string cpf) :base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor");
        }

        public override void AumentarSalario() {
            this.Salario *= 1.15;
        }

    }
}

