using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaSchool.Coffees
{
    public abstract class Coffee
    {
        public virtual void Make()
        {
            Console.WriteLine("Готовим кофе");
        }


    }
}
