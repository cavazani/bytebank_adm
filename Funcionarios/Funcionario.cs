using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios {
    public class Funcionario 
    {

        //0 - funcionario
        //1 - diretor
        //2 - designer
        //N - ...
        //private int _tipo;

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }


        //Palavra Virtual informa que o metodo(GetBonificacao) pode ser redefinido na classe filho
        public virtual double GetBonificacao() 
        {   
          return Salario * 0.10;  
            
        }
    }
}
