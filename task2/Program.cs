int number = 2; //создал и задал небольшое значение (формула тяжелая)
int number2 = 3; //создал и задал небольшое значение (формула тяжелая)

int Ackermann(int m, int n) //собственно функция - принимает 2 целых аргумента
    {
        if (m == 0) //проверяем на равеновство и первое вхождение
        {
            return n + 1;
        }
        else if (m > 0 && n == 0) //доп. условие
        {
            return Ackermann(m - 1, 1); //еще одно
        }
        else // m > 0 && n > 0
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

System.Console.WriteLine(Ackermann(number,number2)); //вывод и вызов функции