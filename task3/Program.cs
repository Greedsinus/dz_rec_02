
int[] array = { 1, 2, 8, 4, 9 }; //создал и сразу инициировал массив, можно рандомом или по вводу - но по ТЗ оно не надо
PrintReversed(array, array.Length - 1); //вызов функции
    

    static void PrintReversed(int[] arr, int index) //собственно функция
    {
        if (index < 0)
        {
            return; // базовый случай: когда индекс выходит за пределы массива с начальной стороны
        }
        Console.Write(arr[index] + " "); // вывод текущего элемента
        PrintReversed(arr, index - 1); // рекурсивный вызов функции для предыдущего элемента
    }