using System.Diagnostics.Eventing.Reader;
using System.Linq;
using Entidades;

namespace Operador
{
    public class Operacoes : Entidade
    {
        public void Operacao(string oper)
        {
            operacao = oper;
        }
        //public bool  ContainsOperacao => operacao.Any();

        public double? RealizarOperacao(double n2)
        {
            if (operacao == "")
                n1 = n2;
            else 
                switch (operacao)
                {
                    case "+":
                        n1 += n2;
                        break;

                    case "-":
                        n1 -= n2;
                        break;

                    case "*":
                        n1 *= n2;
                        break;

                    case "/":
                        n1 /= n2;
                        break;
                }
            return n1;
        }

        public void Limpar()
        {
            n1 = 0;
            operacao = "";
        }
    }
}
