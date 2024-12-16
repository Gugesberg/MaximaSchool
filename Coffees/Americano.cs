using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaSchool.Coffees
{
    public class Americano : Coffee
    {
        public override void Make()
        {
            Console.WriteLine("Ваш Американо готов");
        }
    }
}
