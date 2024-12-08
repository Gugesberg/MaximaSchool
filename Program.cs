using MaximaSchool;

Coffee latte = new Coffee("Латте", 300, 1, true);
Coffee espresso = new Coffee("Эспрессо", 100, 3, false);
Coffee cappuccino = new Coffee("Капучино", 250, 2, true);
Coffee flatWhite = new Coffee("Флэт Уайт", 250, 2, true);
Coffee americano = new Coffee("Американо", 150, 3, false);

Console.WriteLine("Введите id кофе, который необходимо приготовить");
Console.WriteLine("1 - Латте, 2 - Эспрессо, 3 - Капучино, 4 - Флэт Уайт, 5 - Американо ");
int coffeeIndex = int.Parse(Console.ReadLine());
Coffee.CoffeeMaker(coffeeIndex);

