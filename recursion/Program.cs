using CsharpMethods;

Recursion recurs = new Recursion();
int[] intArray = { 1, 2, 3, 4, 5, 8, 12, 17};
//recurs.rec(5);
Console.WriteLine("\n Task 1:");
recurs.MToN(10, 23);
Console.WriteLine("\n Task 2:");
Console.WriteLine(recurs.AkkermanFunction(2, 3));
Console.WriteLine(" \n Task 3:");
recurs.printRecArrayVer1(intArray, intArray.Length - 1);