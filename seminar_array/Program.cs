// Массивы

//Нати произведение пар чисел

int[] arrayInput = { 1, 3, 5, 6, 8, -10, 5 };

int[] composition(int[] a)
{
    int arrayLen = a.Length;
    bool even = arrayLen % 2 == 0 ? true : false; //избыточно
    int maxIndex = arrayLen / 2;
    int[] outArray = new int[maxIndex];
    if (arrayLen > 1)
    {
        for (int i = 0; i < maxIndex; i++)
        {
            outArray[i] = a[i] * a[(arrayLen - 1) - i];
        }
    }
    return outArray;
}

void printArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}
printArray(composition(arrayInput));


int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
int CountItemsRange(int[] numbers, int minRange, int maxRange)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (10 < numbers[i] && numbers[i] < 90) count++;
    }
    return count;
}

void PrintResult(int[] array)
{
    //int[] resultArray = new int[CountItemsRange(array)];
    int maxCount = CountItemsRange(array, 10, 90);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //if(count < resultArray.Lenght)
        //{
        //if(10 < array[i] < 90) resultArray[count];
        //count++; 
        //}
        if (count == maxCount)
        {
            break;
        }
        else if (10 < array[i] && array[i] < 90)
        {
            Console.Write(array[i] + " ");
            count++;
        }
    }
}

PrintResult(array);


