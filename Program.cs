// See husing System.Globalization;

namespace FirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1 - Камень");
            Console.WriteLine(" 2 - Ножницы");
            Console.WriteLine(" 3 - Бумага");
            Console.WriteLine("Введите название команды для игрока 1");

            int player1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название команды для игрока 2");
            int player2 = Convert.ToInt32(Console.ReadLine());

            if (player1 == player2)
            {
                Console.WriteLine("Ничья");
            }
            else if ((player1 == 1 && player2 == 2) || (player1 == 2 && player2 == 3) || (player1 == 3 && player2 == 1))


            {
                Console.WriteLine("Победа Игрока 1");
            }
            else
            {
                Console.WriteLine("Победа Игрока 2");
            }

            Console.ReadKey();
        }

    }
}
