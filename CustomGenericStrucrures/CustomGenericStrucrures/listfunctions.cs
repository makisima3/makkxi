using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenericStructures;

namespace listfunc
{
    public class listfunctions
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
            foreach (var c in list)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
