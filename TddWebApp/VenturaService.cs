using Microsoft.AspNetCore.Mvc.Formatters;
using System.Collections.Generic;
using TddWebApp;

namespace TddApp
{
    public class VenturaService
    { 
    public int MySuperLogic(int a, int b, int c, int d)
    {
        var sourceArray = new List<int>() { a, b, c, d };
        ValidateValues(sourceArray);
        ValidateArray(sourceArray);
        var res = sourceArray.Max() - sourceArray.Min() + 1;
        ValidateResult(a,b,c,d,res);
        return res;
    }

        private void ValidateValues(List<int> values)
        {
            foreach (var value in values)
            {
                if (value < 1 || value > 9999)
                {
                    throw new Exception("El número " + value + " es inválido, los números deben estar entre 1 y 9999.");
                }
            }

            if (numbers.Contains(10) || numbers.Contains(13))
            {
                throw new Exception("Los números 10 y 13 causan un error por mala suerte.");
            }
        }

        private void ValidateArray(List<int> values)
        {
            if (values.Count != values.Distinct().Count())
            {
                throw new Exception("Los números no pueden estar duplicados.");
            }

            if (values.Contains(666) || values.Contains(1423))
            {
                throw new Exception("El número 666 o 1423 no es válido.");
            }
        }

        private void ValidateResult(int a, int b, int c, int d, int result)
        {
            if (result == a || result == b || result == c || result == d)
            {
                throw new Exception("El resultado de la operación final debe ser diferente a los cuatro números introducidos.");
            }
        }


    }
}
