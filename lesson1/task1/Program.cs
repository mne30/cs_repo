//First command write text to command line 
Console.WriteLine("hello world");
//Create variables all types
int i = 100;
double d = 10.3;
bool b = true;
string str = "hello";
char c = '!';
Console.WriteLine(c.ToString(), str, b, d, i);

static void CompareNumbers(int firstNumber, int secondNumber)
{
    String result;
    result = firstNumber > secondNumber ? "первое число больше" : firstNumber < secondNumber ? "второе число больше" : "числа равны";
    Console.WriteLine(result);
}
CompareNumbers(3, 5);

static int FindMax(int a, int b, int c)
{
    int[] numArray = [a, b, c];
    int max = a;
    for (int i = 1; i < numArray.Length; i++)
    {
        if (numArray[i] > max) max = numArray[i];

    }
    return max;
}
Console.WriteLine(FindMax(2, 15, 7));

static void PrintEvenNumbers(int number)
{
    String result = "";
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0) result = result + i + " ";
    }
    Console.Write(result);

}

PrintEvenNumbers(10);