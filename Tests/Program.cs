using System.Linq.Expressions;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1211 };


            List<int> y = x.ToList();

            List<int> suivant = new List<int>();

            foreach (int i in y)
            {
                suivant.Add(i);
                Console.WriteLine(i);
            }
            suivant.Sort();
            foreach (int i in suivant)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine(y.Capacity);
            Console.WriteLine(suivant.Capacity);
        }
    }
}