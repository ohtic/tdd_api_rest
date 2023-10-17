using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Collections.Generic;
using TddWebApp;

namespace TddApp
{
    public class EsteveService
    {
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
            });

            if (list.Distinct().Count() < 4)
                throw new Exception("Los números no pueden estar duplicados.");
        }
    }
}
