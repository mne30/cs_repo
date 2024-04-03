using System;
using System.Text;
// Урок 6. Массивы и строки
// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] chArray = new char[,]{
    {'c', 'h', 'a', 'r'},
    {'a', 'r', 'r', 'a'}
};

string splitCharToString(char[,] arrayCh)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < arrayCh.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCh.GetLength(1); j++)
        {
            sb.Append(chArray[i, j].ToString());
        }
        sb.Append(" ");
    }
    //string result = sb.ToString();
    return sb.ToString();
}

string splitCharToStringInsert(char[,] arrayCh)
{
    string result = "";
    for (int i = 0; i < arrayCh.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCh.GetLength(1); j++)
        {
            result = result.Insert(result.Length, arrayCh[i, j].ToString());
        }
        result = result.Insert(result.Length, " ");
    }
    return result;
}

string splitCharToStringConcatenation(char[,] arrayCh)
{
    string result = "";
    for (int i = 0; i < arrayCh.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCh.GetLength(1); j++)
        {
            result = result + arrayCh[i, j].ToString();
        }
        result = result + " ";
    }
    return result;
}

Console.WriteLine(splitCharToString(chArray));
Console.WriteLine(splitCharToStringInsert(chArray));
Console.WriteLine(splitCharToStringConcatenation(chArray));



// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
string str1 = "AaBbCcDd";
string str2 = str1.ToLower();
Console.WriteLine(str2);

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string palindrom = "радар";
string palindrom2 = "старик";
string palindrom3 = "дед";

bool validationPalindrom(string str)
{
    bool result = true;
    int countIter = str.Length / 2;
    for (int i = 0; i < countIter; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            result = false;
            break;
        }
    }
    return result;
}

Console.WriteLine(validationPalindrom(palindrom));
Console.WriteLine(validationPalindrom(palindrom2));
Console.WriteLine(validationPalindrom(palindrom3));

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string txt = "Я пытаюсь догнать свою группу делая дз";

string replaceWords(string str)
{
    string[] strArray = str.Split(new char[] { ' ' });
    int countIter = strArray.GetLength(0) / 2;
    return ValueArrayToString(ConvertStringArray(strArray, countIter));
}

string[] ConvertStringArray(string[] strArray, int countIter)
{
    for (int i = 0; i < countIter; i++)
    {
        string temp = strArray[i];
        strArray[i] = strArray[strArray.GetLength(0) - 1 - i];
        strArray[strArray.GetLength(0) - 1 - i] = temp;
    }
    PrintArray(strArray);
    return strArray;
}

string ValueArrayToString(string[] strArray){
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < strArray.GetLength(0); i++){
        if(i == strArray.GetLength(0) - 1){
            sb.Append(strArray[i]);
            break;
        }
        sb.Append(strArray[i] + " ");
    }
    return sb.ToString();
}

void PrintArray(string[] str)
{
    foreach (string e in str)
    {
        Console.WriteLine(e);
    }
}

Console.WriteLine(replaceWords(txt));