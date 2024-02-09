
System.Console.WriteLine("enter u number");
int n = Convert.ToInt32(Console.ReadLine()); //задал переменную с точным названием из задания, мне так было удобнее
System.Console.WriteLine("enter u number");
int m = Convert.ToInt32(Console.ReadLine()); //задал переменную с точным названием из задания, мне так было удобнее

int NaturalNumbers(int min, int max) //функция, создаем
{
    if (min > max)
    {
        return 0;   //выход из рекурсии
    }

    System.Console.Write(min + " "); //вот тут мне было удобнее сделать вывод, в строку с разделением

    return NaturalNumbers(min +1, max); //собственно решение + рекурсия

} 

NaturalNumbers(n, m); //вызвал функцию