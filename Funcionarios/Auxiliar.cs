using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios {
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 3000) {
            Console.WriteLine("Criando um diretor");
        }

        public override double GetBonificacao() {
            return Salario + 1.11;
        }


        public override void AumentarSalario() {
            this.Salario *= 1.17;
        }
    }
}
