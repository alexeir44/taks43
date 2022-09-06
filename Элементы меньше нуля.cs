// Массив целых чисел
int[] CreateArray (int size)
{
    int[] array = new int[size];
    Console.Write("Вы хотите создать массив случайных чисел? (yes/no) ");
    string? choice = Console.ReadLine();
    if (choice == "yes")
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(-25, 26);
        }
    }
    else if (choice == "no")
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите {i+1} элемемнт массива: ");
            array[i] = CorrectInput();
        }
    }
    else 
    {
        Console.WriteLine("Ошибка ввода команды, Запустите программу заново.");
    }
    return array;
}   

// Анализ чисел массива
int lessNull(int[] array)
{
    int result = 0;
    foreach (int element in array)
    {
        result += element < 0 ? 1: 0;
    }   
    return result;
}

// Проверка ввода чисел
int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

// Код программы
Console.Write("Введите размер массива: ");
int userSize = CorrectInput();
int[] userArray = CreateArray(userSize);

Console.WriteLine("Ваш массив: " + string.Join(" ", userArray));

Console.Write($"В массиве {lessNull(userArray)} элемент(-а/-ов) меньше нуля.");