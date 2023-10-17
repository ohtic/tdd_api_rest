using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using TddWebApp;
using TddWebApp.Models;

namespace TddApp
{
    public class DiazService : IDiazService
    { 
        List<int> _discartedValues = new List<int>
        {
            10,666,13,1423
        };
        const int _minRangeNumber = 1;
        const int _maxRangeNumber = 9999;
        const int _ouijaNumber = 666;
        List<int> _unlukyNumbers = new List<int>
        {
            10,13
        };

        public ResponseModel MySuperLogic(int a, int b, int c, int d)
        {
            var response = new ResponseModel();
            var sourceArray = new List<int>() { a, b, c, d };
            ValidateValues(sourceArray);
            ValidateArray(sourceArray);
            response.Result = sourceArray.Max() - sourceArray.Min() + 1;
            return response;
        }

        private void ValidateValues(List<int> sourceArray)
        {
            foreach (var number in sourceArray)
            {

                if (_unlukyNumbers.Contains(number))
                {
                    throw new Exception($"Los números 13 y 10 causan un error por mala suerte.");
                }

                if(number == _ouijaNumber)
                {
                    throw new Exception("El número 666 no es valido revise su ouija de confianza para más información.");
                }

               if (number < _minRangeNumber || number > _maxRangeNumber)
               {
                    throw new Exception($"El número {number} no es valido revise su ouija de confianza para más información.");  
               }

            }

            var hasDuplicates = sourceArray.GroupBy(x => x).Any(g => g.Count() > 1);
            if (hasDuplicates)
            {
                throw new Exception("Los números no pueden estar duplicados");
            }


        }

        private void ValidateArray(List<int> sourceArray)
        {
            var hasDiscartedValues = sourceArray.Any(x => _discartedValues.Contains(x));
            if (hasDiscartedValues)
            {
                throw new Exception($"The array contains invalid numbers");
            }
        } 
    }
}
