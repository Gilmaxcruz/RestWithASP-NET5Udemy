using RestWithASPNETUdemy.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Service
{
    public class CalculatorService : ICalculatorService
    {


        
        private bool IsNumeric(string strnumber)
        {
            double number;
            bool isNumber = double.TryParse(strnumber, System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strnumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strnumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private double ConvertTodouble(string strnumber)
        {
            double doubleValue;
            if (double.TryParse(strnumber, out doubleValue))
            {
                return doubleValue;
            }
            return 0;
        }

        public string Somar(string firsNumber, string secundNumber)
        {
            if (IsNumeric(firsNumber) && IsNumeric(secundNumber))
            {

                var sum = ConvertToDecimal(firsNumber) + ConvertToDecimal(secundNumber);
                return sum.ToString();

            }
            return string.Empty;
        }

        public string Subtracao(string firsNumber, string secundNumber)
        {
            if (IsNumeric(firsNumber) && IsNumeric(secundNumber))
            {

                var Subtracao = ConvertToDecimal(firsNumber) - ConvertToDecimal(secundNumber);
                return Subtracao.ToString();

            }
            return string.Empty;
        }

        public string Multiplicacao(string firsNumber, string secundNumber)
        {
            if (IsNumeric(firsNumber) && IsNumeric(secundNumber))
            {

                var Multiplicacao = ConvertToDecimal(firsNumber) * ConvertToDecimal(secundNumber);
                return Multiplicacao.ToString();

            }
            return string.Empty;
        }

        public string Divisao(string firsNumber, string secundNumber)
        {
            if (IsNumeric(firsNumber) && IsNumeric(secundNumber))
            {

                var Divisao = ConvertToDecimal(firsNumber) / ConvertToDecimal(secundNumber);
                return Divisao.ToString();

            }
            return string.Empty;
        }

        public string Media(string firsNumber, string secundNumber)
        {
            if (IsNumeric(firsNumber) && IsNumeric(secundNumber))
            {

                var Media = (ConvertToDecimal(firsNumber) + ConvertToDecimal(secundNumber)) / 2;
                return Media.ToString();

            }
            return string.Empty;
        }

        public string Raiz(string firsNumber)
        {
            if (IsNumeric(firsNumber)) 
            {
               double firsNumber1 = (ConvertTodouble(firsNumber));
                var Raiz = Math.Sqrt(firsNumber1);
                return Raiz.ToString();

            }
            return string.Empty;
        }
    }
}
