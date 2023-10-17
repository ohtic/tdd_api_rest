namespace TddApp
{
    public class CiroService
    {
        public int MySuperLogic(int a, int b, int c, int d)
        {
            var sourceArray = new List<int>() { a, b, c, d }; ;
            var res = sourceArray.Max() - sourceArray.Min() + 1;

            return res;
        }
    }
}