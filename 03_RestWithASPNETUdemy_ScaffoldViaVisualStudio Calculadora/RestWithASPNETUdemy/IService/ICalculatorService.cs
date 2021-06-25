using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Iservice
{
   public interface ICalculatorService
    {

        string Somar(string firsNumber, string secundNumber);
        string Subtracao(string firsNumber, string secundNumber);
        string Multiplicacao(string firsNumber, string secundNumber);
        string Divisao(string firsNumber, string secundNumber);
        string Media(string firsNumber, string secundNumber);
        string Raiz(string firsNumber);
    }
}
