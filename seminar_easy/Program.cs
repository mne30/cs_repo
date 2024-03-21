

// task 1
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int[] numbers = {7, 23};

bool multiple(int a)
{
    bool result = a % numbers[0] == 0 && a % numbers[1] == 0 ? true : false;
    return result;
} 

Console.WriteLine(multiple(userNum));

// task 2
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

string searchPath(int x, int y) 
{
    if ( x  == 0 || y == 0){
        return "Аргумент не может быть равен 0";
    }
    string result = x < 0 && y > 0 ? "1 path" : x > 0 && y > 0 ? "2 path" : x < 0 && y < 0 ? "3 path" : "4 path";
    return result;  
}
Console.WriteLine(searchPath(x, y));

// task 3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int userNum2;

while(true){
    Console.Write("Введите число от 10 до 99: ");
    userNum2 = Convert.ToInt32(Console.ReadLine());
    if (10 <= userNum2  && userNum2 <= 99){
        break;
    }
}
int checkNum (int num){
    return num / 10 > num % 10 ? num / 10 : num % 10;
    
}

Console.WriteLine(checkNum(userNum2));

// task 4
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите число (Задача 4): ");
int userNum3 = Convert.ToInt32(Console.ReadLine());

int checkLength(int a){
    string s = Convert.ToString(a);
    return s.Length;
}

string outputNum (int a){
    int i = checkLength(a) - 1;
    int denominator = 1;
    while(i > 0){
        denominator *= 10;
        i--;
    }
    i = checkLength(a) - 1;
    while( i >= 0){
        if (i == 0){
            Console.Write(userNum3);
            break;
        }
        Console.Write((userNum3 / denominator) + ", ");
        userNum3 %= denominator;
        denominator /= 10;
        i--;
    }
    return "  DONE";
    }

Console.WriteLine(outputNum(userNum3));

