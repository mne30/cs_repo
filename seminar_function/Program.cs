
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.




void inputNum()
{
    while (true)
    {
        Console.Write("Введите число: ");
        string inConsole = Console.ReadLine();
        int numLength = inConsole.Length;
        if (inConsole == "q")
        {
            Console.WriteLine("Программа завершено, статус 0!");
            break;
        }
        int convNumStr = Int32.Parse(inConsole);
        if (numLength == 1 && convNumStr % 2 == 0)
        {
            Console.WriteLine("Программа завершено, статус 0!");
            break;
        }
        else if (numSum(convNumStr, numLength))
        {
            Console.WriteLine("Программа завершено, статус 0!");
            break;
        }
    }
}

bool numSum(int number, int numLength)
{
    int[] numbers = new int[numLength];
    int demention = 1;
    int sum = 0;
    for (int i = 0; i < numLength - 1; i++)
    {
        demention *= 10;
    }
    for (int i = 0; i < numLength; i++)
    {
        if (i == numLength - 1) numbers[i] = number;
        numbers[i] = number / demention;
        number -= numbers[i] * demention;
        demention /= 10;
        sum += numbers[i];
    }
    return sum % 2 == 0;
}

inputNum();

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int[] generationNum(int amount)
{
    int[] numbers = new int[amount];
    Random rnd = new Random();
    for (int i = 0; i < amount; i++)
    {
        numbers[i] = rnd.Next(100, 999);
    }
    return numbers;
}

int[] arrayNum = generationNum(5);

int amountEven(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) amount++;
    }
    return amount;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

printArray(arrayNum);
Console.Write(amountEven(arrayNum));

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент 
// станет последним, второй – предпоследним и т.д.)

//     string[] convertingArrays(string[] array)
// {
//     string temp = "";
//     int maxIndex = array.Length - 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         temp = array[i];
//         array[i] = array[maxIndex - i];
//         array[maxIndex - i] = temp;
//     }
//     return array;
// }

string[] strArray =
{
        "string1",
        "string2",
        "string3",
    };

string[] convertingArrays(string[] array)
{
    //string[] arrN = new string[array.Length];
    string temp = "";
    int maxIndex = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        //arrN[i] = array[maxIndex - i];
        temp = array[i];
        array.SetValue(array[maxIndex - i], i);
        array.SetValue(temp, maxIndex - i);
    }
    //printArrayStr(array);
    return array;
}
void printArrayStr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

string[] newStr = convertingArrays(strArray);
printArrayStr(newStr);


//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
  };

int x = 2;
int y = 2;

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Поиск элемента по позициям
static int FindElementByPosition(int[,] array, int x, int y)
{
    return array[x - 1, y - 1];
}

// Проверка позиций на вхождение в массив
static bool ValidatePosition(int[,] array, int x, int y)
{
    if (x > array.Length - 1)
    {
        Console.Write("Выход за пределы массива");
        return false;
    }
    else if (y > array.GetLength(1) - 1)
    {
        Console.Write("Выход за пределы массива");
        return false;
    }
    return true;
}

static void PrintResult(int[,] numbers, int x, int y)
{
    if(ValidatePosition(numbers, x, y)){
        Console.Write(FindElementByPosition(numbers, x, y));
    }
    
}
PrintResult(numbers, x, y);
