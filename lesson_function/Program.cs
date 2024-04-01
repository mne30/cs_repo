using lesson_function;

 // task 1
MathFunction mf = new MathFunction();
int result = mf.function1(10, 3, 4, 6);
Console.Write(result);

Console.Write("Представьтесь: ");
string name = Console.ReadLine();
Console.Write("Введите количество вопросов: ");
int amountQ = Int32.Parse(Console.ReadLine());

Victorina vic1 = new Victorina(amountQ, name);
vic1.game();





