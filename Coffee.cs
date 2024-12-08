using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximaSchool
{
    public class Coffee
    {
        public string Name { get; set; } // название напитка
        public int Volume { get; set; } // объем
        public int Fortress { get; set; } // крепость напитка
        public bool WithMilk { get; set; }// наличие молока

        public Coffee(string newName, int newVolume, int newFortress, bool newWithMilk)
        {
            Name = newName;
            Volume = newVolume;
            Fortress = newFortress;
            WithMilk = newWithMilk;
        }

        public static void CoffeeMaker(int coffeeIndex)
        {
            if (coffeeIndex == 1)
            {
                Console.WriteLine("Ваш Латте готов");
            }
            else if (coffeeIndex == 2)
            {
                Console.WriteLine("Ваш Эспрессо готов");
            }
            else if (coffeeIndex == 3)
            {
                Console.WriteLine("Ваш Капучино готов");
            }
            else if (coffeeIndex == 4)
            {
                Console.WriteLine("Ваш Флэт Уайт готов");
            }
            else if(coffeeIndex == 5)
            {
                Console.WriteLine("Ваш Американо готов");
            }
            else
            {
                Console.WriteLine("Неверный номер напитка");
            }

            }

    }  
} 
