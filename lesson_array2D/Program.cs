// Two-dimensional arrays
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

string[,] testArray = new string[2, 3] { { "bye", "goodbye", "go out" }, { "hello", "ohayo", "good morning" } };

//find value
Console.Write("Input word: ");
string? keyValue = Console.ReadLine();
//Console.WriteLine(keyValue);


int[] findValue(string[,] array, string? key)
{
    int[] result = new int[2];
    bool stat = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.Write(array[i, j]);
            if (array[i, j].Equals(key))
            {
                //Console.Write(array[i, j]);
                result[0] = i;
                result[1] = j;
                stat = true;
            }
        }
        if (stat)
        {
            break;
        }
        else if (i == array.Length - 1)
        {
            result[0] = -99;
            result[1] = -99;
        }
    }
    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

printArray(findValue(testArray, keyValue));

// Random make random number
int makeRand(int start, int stop)
{
    Random rnd = new Random();
    return rnd.Next(start, stop);
}

// Make function which fill an array

int[,] fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = makeRand(10, 100);
        }
    }
    return array;
}
void printArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] rndArray = new int[2, 5];
printArray2D(fillArray(rndArray));

//Make random two-dimensional arrays
int[,] makeRand2dArrays(int rows, int cols, int start, int stop)
{
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(start, stop);
        }
    }
    return array;
}


void validation(int[,] array)
{
    int rows = array.GetLength(0);
    int[][] res = new int[rows][];
    List<int> lInt = new List<int> { };
    //printArray2D(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        lInt.Clear();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                lInt.Add(array[i, j]);
                //Console.WriteLine(array[i, j] + " четное, вносим в список");
            }

        }
        res[i] = lInt.ToArray();
        // Console.WriteLine(lInt);
        // for (int g = 0; g < lInt.Count; g++)
        // {
        //     Console.WriteLine(lInt[g] + " ");
        // }
        // Console.WriteLine();

    }
    Console.WriteLine("Печать массива массивов: ");
    printArrayArrayes(res);

}

void printArrayArrayes(int[][] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] arrayTemp = array[i];
        for (int j = 0; j < arrayTemp.Length; j++)
        {
            Console.Write(arrayTemp[j] + " ");
        }
        Console.WriteLine();
    }
}
validation(makeRand2dArrays(4, 6, 10, 70));

// Strings 
// Read string and create new string with letter

Console.Write("Input your phrase: ");
string? userInput = Console.ReadLine();

string replaceLetterOfString(string word)
{
    string result = "";
    int lenString = word.Length;
    List<int> listInt = rndIntegerList(lenString);
    for (int i = 0; i < listInt.Count; i++)
    {
        result = result + word[listInt[i]];
    }
    return result;
}

List<int> rndIntegerList(int count)
{
    List<int> listInt = new List<int> { };
    Random rndInteger = new Random();
    while (true)
    {
        if (listInt.Count == count) break;
        int temporaryInteger = rndInteger.Next(0, count);
        int cost = 0;

        foreach (int e in listInt)
        {
            if (e == temporaryInteger) cost++;
        }
        if (cost == 0) listInt.Add(temporaryInteger);
    }
    for (int g = 0; g < listInt.Count; g++)
    {
        Console.Write(listInt[g] + " ");
    }
    Console.WriteLine();
    return listInt;
}
rndIntegerList(9);

Console.WriteLine(replaceLetterOfString(userInput));

// Operation with string
string s1 = " hello";
string s2 = "world";
string s5 = "nihayo";
// Trim string
string s3 = s1.Trim(new char[] { ' ', 'h', 'o' });
Console.WriteLine(s3);
// TrimStart string
string s4 = s2.TrimStart('w', 'o');
Console.WriteLine(s4);
// Isert string 
s1 = s1.Insert(s1.Length, s5);
Console.WriteLine(s1);
// Substring string cut substring
s5 = s5.Substring(0, s5.Length - 2);
Console.WriteLine(s5);
string s6 = "Kondratev";
// IndexOf string find index in string
int indexOfString = s6.IndexOf('d');
Console.WriteLine(indexOfString);
// Split strings 
string s7 = "так хорошо знать язык программирования";
string[] words = s7.Split(new char[] { ' ' });
void printSplitWords(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        Console.WriteLine(words[i]);
    }

}
printSplitWords(words);
// Replace substring in string 
string s8 = "Привет меня зовут, Имя";
s8 = s8.Replace("Имя", "Роман");
Console.WriteLine(s8);

int[,] numbers = new int[,] {
      {1, 2, 3, 4},
      {5, 6, 7, 8},
      {9, 10, 11, 12}
    };
int x = 2;
int y = 2;
bool valid(int[,] array, int x, int y)
{
    bool valid = (x >= array.GetLength(0) || y >= array.GetLength(1) ? false : true);
    return valid;
}



static int FindElementByPosition(int[,] array, int x, int y)
{
    if (!ValidatePosition(array, x, y))
    {
        Console.WriteLine("Выход за границы массива!");
        return -99;
    }
    Console.WriteLine("В пределах массива!");
    Console.WriteLine(array[x, y]);
    return array[x, y];
}

// Проверка позиций на вхождение в массив
static bool ValidatePosition(int[,] array, int x, int y)
{
    bool valid = x >= array.GetLength(0) || y >= array.GetLength(1) ? false : true;
    return valid;

}

static void PrintResult(int[,] numbers, int x, int y)
{
    Console.Write(FindElementByPosition(numbers, x, y));
}

PrintResult(numbers, x, y);



int[,] numbers1 = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
    };
// Печать массива
static void PrintArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Обмен первой с последней строкой
static int[,] SwapFirstLastRows(int[,] array)
{
    SwapItems(array, 0);
    return array;
}

// Обмен элементами массива
static void SwapItems(int[,] array, int i)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[i, j];
        array[i, j] = array[(array.GetLength(0) - 1), j];
        array[(array.GetLength(0) - 1), j] = temp;
    }
}

static void PrintResult1(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//PrintResult1(SwapFirstLastRows(numbers1));




Console.WriteLine();
int[,] numbers2 = new int[,] {
      {10, 22, 38, 42},
      {5, 6, 7, 8},
      {74, 10, 121, 172}
    };
static void PrintArray11(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Обмен первой с последней строкой
static int[,] SwapFirstLastRows1(int[,] array)
{
    SwapItems1(array, 0);
    return array;
}

// Обмен элементами массива
static void SwapItems1(int[,] array, int i)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[i, j];
        array[i, j] = array[(array.GetLength(0) - 1), j];
        array[(array.GetLength(0) - 1), j] = temp;
    }
}

static void PrintResult11(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintResult11(SwapFirstLastRows1(numbers2));
