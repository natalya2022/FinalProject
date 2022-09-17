
string[] Prompt(string message)               // Функция, на вход получает параметр, возвращает массив строк
{
    System.Console.Write(message);
    return Console.ReadLine().Split(" ");    // Считывает с консоли текст, разбивает на массив строк, разделитель " ", возвращает массив
}

void ArrayPrint(string[] myString)           // Функция печати массива, каждый элемент с новой строки  
{
    for (int j = 0; j < myString.Length; j++)
    {
        System.Console.WriteLine(myString[j]);
    }
}

string[] CopyArrayWords3(string[] myString)   // Функция копирует в новый массив строки по условию задачи 
{
    string[] arrayWords = new string[myString.Length];
    int j = 0;
    for (int i = 0; i < myString.Length; i++)
    {
        if (myString[i].Length <= 3 && myString[i].Length > 0)
        {
            arrayWords[j] = myString[i];
            j = j + 1;
        }
    }
    Array.Resize(ref arrayWords, j);        // Убираем пустые строки в конце массива
    return arrayWords;
}

void Main()
{
    string[] myString = Prompt("Введите строку, завершите ввод нажатием клавиши Enter > ");    // Вводим текст с клавиатуры
    string[] arrayWords = CopyArrayWords3(myString);
    System.Console.WriteLine("--- Исходный массив ---");
    ArrayPrint(myString);
    System.Console.WriteLine("--- Результирующий массив ---");
    ArrayPrint(arrayWords);
}

Main();