using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using TddWebApp;

namespace TddApp
{
    public class VenturaService
    { 
        public int MySuperLogic(int num1, int num2, int num3, int num4)
        {
            var sourceArray = new List<int>() { num1, num2, num3, num4 };

            ValidateValues(sourceArray);

            ValidateArray(sourceArray);

            var res = sourceArray.Max() - sourceArray.Min() + 1;

            ValidateResult(num1, num2, num3, num4, res);

            return res;
        }

        private void ValidateValues(List<int> values)
        {
            values.ForEach(value =>
            {
                if (value.ToString().Length > 4)
                {
                    throw new Exception("El valor solo puede ser un int de máximo 4 cifras.");
                }

                if (value < 1 || value > 9999)
                {
                    throw new Exception("El número " + value + " es inválido, los números deben estar entre 1 y 9999.");
                }

                if (values.Contains(10) || values.Contains(13))
                {
                    throw new Exception("Los números 13 y 10 causan un error por mala suerte.");
                }

            });

        }


        private void ValidateArray(List<int> values)
        {
            if (values.Count != values.Distinct().Count())
            {
                throw new Exception("Los números no pueden estar duplicados.");
            }

            if (values.Contains(666))
            {
                throw new Exception("El número 666 no es valido revise su ouija de confianza para más información.");
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
