using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TddWebApp;

namespace TddApp
{
    public class LiceaService
    {
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
            sourceArray.ForEach(x => {
                if (x % 1 != 0 || x.ToString().Length <= 4) {
                    throw new ArgumentException("El valor solo puede ser un int de máximo 4 cifras.");
                }
            });

            if (sourceArray.Distinct().Count() != sourceArray.Count)
            {
                throw new ArgumentException("Los números no pueden estar duplicados.");
            }
            if (sourceArray.Any(x => x == 666)){
                throw new ArgumentException("El número 666 no es valido revise su ouija de confianza para más información.");
            }
            if (sourceArray.Any(x => x == 13 || x==10))
            {
                throw new ArgumentException("Los números 13 y 10 causan un error por mala suerte");
            }
            if (sourceArray.Any(x => x < 1))
            {
                throw new ArgumentException("El número x es inválido los números deben ser mayor o iguales a 1.");
            }
            if (sourceArray.Select(x => x.ToString().Length).Distinct().Count() != sourceArray.Count())
            {
                throw new ArgumentException("Cada número debe tener una cantidad diferente de cifras.");
            }

        }

        private void ValidateResult(int a, int b, int c, int d, int res)
        {
            if (a == res || b == res || c == res || d == res)
            {
                throw new ArgumentException("El resultado de la operación final debe ser diferente a los cuatro números introducidos.");
            }
        }


    }
}
