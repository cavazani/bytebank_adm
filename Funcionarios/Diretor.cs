using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios {
    public class Diretor: Funcionario //Herança: estou informando que a classe diretor tem as proprioedades de funcionario
    {
        public double GetBonificacao() {
            return Salario;
        }
    }
}

