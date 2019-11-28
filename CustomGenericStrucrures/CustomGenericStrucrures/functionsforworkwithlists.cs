using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenericStructures;
using IList;

namespace functionsforworkwithlists
{
    public class functions
    {
        public static Random rnd = new Random();

        public static void RandomFill(IList<double> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(Math.Round(rnd.NextDouble(), 2));
            }
        }

        public static void ConsoleWriteList(IList<double> list)
        {
            for (int i =0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
