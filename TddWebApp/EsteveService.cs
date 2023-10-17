using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using TddWebApp;

namespace TddApp
{
    public class EsteveService
    {

        List<int> INVALID_NUMBERS = new List<int>() { 10, 666, 13, 1423 };

        public int MySuperLogic(int a, int b, int c, int d)
        {      
            var list = new List<int>() { a, b, c, d };
            Validate(list);

            return list.Max() - list.Min() + 1;
        }


        void Validate(List<int> list)
        {
            list.ForEach(c =>
            {
                if (c > 9999)
                    throw new Exception("El valor solo puede ser un int de máximo 4 cifras.");
                if(c == 666)
                    throw new Exception("El número 666 no es valido revise su ouija de confianza para más información.");
            });

            if (list.Distinct().Count() < 4)
                throw new Exception("Los números no pueden estar duplicados.");
        }
    }
}
