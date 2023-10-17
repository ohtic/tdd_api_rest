namespace TddApp
{
    public class CiroService
    {
        public int MySuperLogic(int a, int b, int c, int d)
        {
            var sourceArray = new List<int>() { a, b, c, d };
            ValidateValues(sourceArray);
            ValidateArray(sourceArray);
            var res = sourceArray.Max() - sourceArray.Min() + 1;

            return res;
        }

        private void ValidateValues(List<int> array)
        {
            if (array.Exists(x => x.ToString().Length > 4)) throw new LogicValidationException(410, "El valor solo puede ser un int de máximo 4 cifras");

            if (array.Exists(x => x == 666)) throw new LogicValidationException(450, "El número 666 no es valido revise su ouija de confianza para más información");

            var toExclude = new List<int>() { 13, 10 };
            if (array.Where(x => toExclude.Contains(x)).Any()) throw new LogicValidationException(555, "Los números 13 y 10 causan un error por mala suerte");

            foreach (int item in array) if (item < 1) throw new LogicValidationException(400, $"El número {item} es inválido los números deben ser mayor o iguales a 1");
        }

        private void ValidateArray(List<int> array)
        {
            if (array.GroupBy(x => x).Any(g => g.Count() > 1)) throw new LogicValidationException(418, "Los números no pueden estar duplicados");
        }
    }

    public class LogicValidationException : Exception
    {
        public LogicValidationException(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public int Code { get; }
        public new string Message { get; }
    }
}