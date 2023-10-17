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
            return list.Max() - list.Min() + 1;
        }
    }
}
