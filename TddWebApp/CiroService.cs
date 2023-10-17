namespace TddApp
{
    public class CiroService
    {
        public int MySuperLogic(int a, int b, int c, int d)
        {
            var sourceArray = new List<int>() { a, b, c, d };
            ValidateValues(sourceArray);
            var res = sourceArray.Max() - sourceArray.Min() + 1;

            return res;
        }

        private void ValidateValues(List<int> array)
        {
            if (array.Exists(x => x.ToString().Length > 4)) throw new LogicValidationException(410, "El valor solo puede ser un int de máximo 4 cifras");
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