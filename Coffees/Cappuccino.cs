using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaSchool.Coffees
{
    public class Cappuccino : Coffee
    {
        public override void Make()
        {
            Console.WriteLine("Ваш капучино готов");
        }
    }
}
