using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios {
    public abstract class Funcionario 
    {

        //0 - funcionario
        //1 - diretor
        //2 - designer
        //N - ...
        //private int _tipo;

        public string Nome { get; set; }
        public string Cpf { get;private set; }
        public double Salario { get; protected set; }


        //Palavra Virtual informa que o metodo(GetBonificacao) pode ser redefinido na classe filho
        public virtual double GetBonificacao(){   
          return Salario * 0.10;  
        }

        //Static informa que a propriedade é da classe e não do objeto
        public static int totalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario) 
         {
            this.Cpf = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um funcionario");
            totalFuncionarios++;
        }

        public virtual void AumentarSalario() 
        {
            this.Salario *= 1.1;
        }
    }
}
