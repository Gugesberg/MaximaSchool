using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MyCustomList2;
using System.Reflection;


using MyCustomList2;
using System.ComponentModel.DataAnnotations;

namespace MaximaSchool
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int> { 1, 2, 3, 4, 5 };
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            var enuemerator = a.GetEnumerator();
            while (enuemerator.MoveNext())
            {
                Console.WriteLine(enuemerator);
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}