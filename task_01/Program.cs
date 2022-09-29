// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Метод вывода массива на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("{0}-й элемент (строка): {1}", i + 1, array[i]);
        Console.WriteLine();
    }
}

// Метод ввода массива с клавиатуры
void InputMas(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите {0}-й элемент (строку): ", i + 1);
        array[i] = Console.ReadLine();
    }
}

// Подсчет количества элементов длина которых <=3 для формирования длины массива в который эти элементы запишутся
int ElementOfShort(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            j++;
    }
    return j;
}

// Заполнение нового массива элементами 1го массива , длина которых <=3
string[] ArrayShort(string[] array)
{
    string[] arrayshort = new string[ElementOfShort(array)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)

        if (array[i].Length <= 3)
        {
            arrayshort[j] = array[i];
            j++;
        }
return arrayshort;
}

Console.Write("Введите длинну массива:");
int lengtharray = int.Parse(Console.ReadLine());
string[] array = new string[lengtharray];
InputMas(array);
/*
 string[] arraymodification = array;
arraymodification = arraymodification.Where(e => e.Length <= 3).ToArray();
Console.WriteLine(String.Join(",", arraymodification));
*/
Console.WriteLine("Элементы нового массива:");
PrintArray(ArrayShort(array));

