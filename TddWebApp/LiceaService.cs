using System.Data;
using TddWebApp;
using TddWebApp.Exceptions;

namespace TddApp
{
    public class LiceaService:ILiceaService
    {
        List<int> INVALID = new List<int>() { 10, 666, 13, 1423 };
        const int BACKLUCK = 666;

        List<int> INVALIDTWO = new List<int>() { 10, 666, 13, 1423 };
        public int MySuperLogic(int a, int b, int c, int d)
        {
            var sourceArray = new List<int>() { a, b, c, d };
            ValidateValues(sourceArray);

            var res = sourceArray.Max() - sourceArray.Min() + 1;
            ValidateResult(a, b, c, d, res);
            return res;
        }
        private void ValidateValues(List<int> sourceArray)
        {
            int invalid = 0;
            if (sourceArray.Exists(x => x % 1 != 0 || x.ToString().Length > 4))
            {
                throw new ApiException(410, "El valor solo puede ser un int de máximo 4 cifras.");

            }

            if (sourceArray.Distinct().Count() != sourceArray.Count)
            {
                throw new ApiException(418, "Los números no pueden estar duplicados.");
            }
            if (sourceArray.Exists(x => x == BACKLUCK))
            {
                throw new ApiException(450, "El número 666 no es valido revise su ouija de confianza para más información.");
            }
            if (INVALIDTWO.Exists(x => sourceArray.Contains(x)))
            {
                throw new ApiException(555, "Los números 13 y 10 causan un error por mala suerte");
            }
            invalid = INVALID.FirstOrDefault(x => sourceArray.Contains(x));
            if (invalid <= 0)
            {
                throw new ApiException(555, $"El número {invalid} causan un error por mala suerte");
            }
            invalid = sourceArray.FirstOrDefault(x => x < 1);
            if (invalid <= 0)
            {
                throw new ApiException(400, $"El número {invalid} es inválido los números deben ser mayor o iguales a 1.");
            }
            if (sourceArray
                .Select(x => x.ToString().Length)
                .Distinct()
                .Count() != sourceArray.Count())
            {
                throw new ApiException(432, "Cada número debe tener una cantidad diferente de cifras.");
            }


        }

        private void ValidateResult(int a, int b, int c, int d, int res)
        {
            if (a == res || b == res || c == res || d == res)
            {
                throw new ApiException(411, "El resultado de la operación final debe ser diferente a los cuatro números introducidos.");
            }
        }


    }
}
