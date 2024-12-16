using MaximaSchool;
using MaximaSchool.Coffees;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Введите номер напитка");
Console.WriteLine("1 - Американо, 2 - Капучино, 3 - Латте, 4 - Флэт Уайт, 5 - Раф ");
var userInput = int.Parse(Console.ReadLine());
var coffeeType = (CoffeeEnum)userInput;
var coffeeMachine = new CoffeeMachine();
coffeeMachine.MakeCoffee(coffeeType);

//Console.WriteLine(drink);

/*
switch (coffeeNumber)
{
    case CoffeeEnum.Americano:
        Console.WriteLine("Ваш американо готов");
        break;
    case CoffeeEnum.Raff:
        Console.WriteLine("Ваш раф готов");
        break;
    case CoffeeEnum.Latte:
        Console.WriteLine("Ваш латте готов");
        break;
    case CoffeeEnum.FlatWhite:
        Console.WriteLine("Ваш флэтУайт готов");
        break;
    case CoffeeEnum.Cappuccino:
        Console.WriteLine("Ваш капучино готов");
        break;
    default:
        Console.WriteLine("Неверный номер напитка");
        break;
        
}
*/
