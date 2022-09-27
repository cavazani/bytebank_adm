using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios {
    public class Funcionario 
    {
        public string nome;
        public string cpf;
        public double salario;

        public double getBonificacao() 
        {
            return salario * 0.1;   
        }
    }
}
