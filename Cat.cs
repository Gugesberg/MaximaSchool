using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaSchool
{
    public class Cat
    {
        private int _age;
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }       
        public string Poroda { get; set; }
        public int Sex { get; set; }

        public Cat()
        {
            Console.WriteLine("Приветы");
        }
        public Cat(string thisName)
        {
            Name = thisName;
        }
        public Cat(string thisName,int thisHeight, int thisWeight, string thisPoroda, int thisSex)
        {
            Name = thisName;
            Height = thisHeight;
            Weight = thisWeight;
            Poroda = thisPoroda;
            Sex = thisSex;
        }
        public int GetHeight( )
        { 
            return Height;
        }
    }
}
