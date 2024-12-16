using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaSchool.Coffees
{
    public class Latte : Coffee
    {
        public override void Make()
        {
            Console.WriteLine("Ваш Латте готов");
        }
    }
}
