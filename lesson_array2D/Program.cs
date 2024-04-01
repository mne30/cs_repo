// Two-dimensional arrays
using System.Runtime.InteropServices.Marshalling;

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

int[,] rndArray = new int[2,5];
printArray2D(fillArray(rndArray));