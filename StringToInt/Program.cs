

using System.Text.RegularExpressions;

try
{
    Console.WriteLine("Введите строку из целых чисел разделенными пробелами");
    string str = Console.ReadLine();

    string resultString = Regex.Replace(str, " {2,}", " ").Trim();
    Console.WriteLine();

    // поиск индекса с недопустимыми символами
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ' && !char.IsNumber(str[i]))
        {
            Console.WriteLine($"Индекс ошибочного символа {i}");
        }

    }



    string[] s = resultString.Split(" ");


    int[] array = ArrayToIntFromString(s);

    if (array.Length >= 2)
    {
        Array.Sort(array);
        Console.WriteLine();

        //вывод отсортированного массива
        Console.WriteLine("Отсортированный массив");
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
        Console.WriteLine($"Разница между макс и мин элементами = {MaxValue(array) - MinValue(array)}");

        //два минимальных элемента

        Console.WriteLine($"Первый минимальный элемент: {array[0]}");
        Console.WriteLine($"Второй минимальный элемент: {array[1]}");
    }
    else
    {
        Console.WriteLine($"Массив должен содержать не менее двух цифр");
    }

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();

static int[] ArrayToIntFromString(string[] s)
{
    int[] array = new int[s.Length];

    for (int i = 0; i < s.Length; i++)
    {

        array[i] = Convert.ToInt32(s[i].ToString());

    }

    return array;
}

static int MinValue(int[] array)
{
    int min = array[0];
    foreach (var item in array)
    {
        if (item < min)
        {
            min = item;
        }
    }

    return min;
}

static int MaxValue(int[] array)
{
    int max = array[0];
    foreach (var item in array)
    {
        if (item > max)
        {
            max = item;
        }
    }

    return max;
}

