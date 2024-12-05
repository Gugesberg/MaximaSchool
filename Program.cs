Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
bool isPalindrom = default;
string strNumber = number.ToString();
for (int i = 0; i < strNumber.Length / 2; i++)
{
    if (strNumber[i] == strNumber[strNumber.Length - i - 1])
    {
        isPalindrom = true;
    }
    else
    {
        isPalindrom = false;
    }
}
if (isPalindrom == true)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}
    


