// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Метод вывода массива на экран
void PrintArray(string[] position)
{
    foreach (var element in position)
        Console.Write($"'{element}', ");
    Console.WriteLine();
}

// Метод ввода массива с клавиатуры
void InputMas(string[] position)
{
    for (int i = 0; i < position.Length; i++)
    {
        Console.WriteLine("Введите {0}-й элемент (строку): ", i + 1);
        position[i] = Console.ReadLine();
    }
}



Console.Write("Введите длинну массива:");
int LengthArray = int.Parse(Console.ReadLine());
string [] array = new string[LengthArray];
InputMas(array);

PrintArray(array);
