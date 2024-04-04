namespace CsharpMethods
{
    public class Recursion
    {
        // public Recursion(){       
        // }
        public void rec(int n)
        {
            if (n == 10)
            {
                return;
            }
            Console.WriteLine($" Выыодим число: {n} ");
            rec(n + 1);
        }

        // Урок 7. Рекурсия

        // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
        public void MToN(int m, int n)
        {
            if (m > n) return;
            Console.Write(m + " ");
            MToN(m + 1, n);
        }

        // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        // A(m - 1, A(m, n - 1)) 
        // Возвращенный 0 будет исключением
        public int AkkermanFunction(int m, int n){
            if(m < 0 || n < 0) return 0;
            //Комбинирую тернарныеые выражения
            return m == 0 ? n + 1 : ( m > 0 && n == 0 ? AkkermanFunction(m - 1, 1) : AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
            //Реализация на if
            // if(m == 0) return n + 1;
            // if(m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
            // return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
        }
        // Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
        public void printRecArrayVer1(int[] intArray, int count){
            if(count < 0) return;
            Console.WriteLine(intArray[count]);
            printRecArrayVer1(intArray, count - 1);
        }


    }
}