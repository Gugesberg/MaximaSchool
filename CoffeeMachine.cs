using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximaSchool.Coffees;

namespace MaximaSchool
{
    public class CoffeeMachine
    {
        public  Coffee MakeCoffee(CoffeeEnum coffeeType)
        {
            Coffee coffee = null; 
            switch (coffeeType)
            {
                case CoffeeEnum.Americano:
                    coffee = new Americano();
                    coffee.Make();
                    break;
                case CoffeeEnum.Raff:
                    coffee = new Raff();
                    coffee.Make();
                    break;
                case CoffeeEnum.Latte:
                    coffee = new Latte();
                    coffee.Make();
                    break;
                case CoffeeEnum.FlatWhite:
                    coffee = new FlatWhite();
                    coffee.Make();
                    break;
                case CoffeeEnum.Cappuccino:
                    coffee = new Cappuccino();
                    coffee.Make();
                    break;
                default:
                    Console.WriteLine("Неверный номер напитка");
                    break;

            }
            return coffee; 
        }
    }
}
