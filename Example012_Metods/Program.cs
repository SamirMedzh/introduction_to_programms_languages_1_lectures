//  Вид 1
void Method1()            // 1 группа метода, ничего не возвращают и ничего не принимают
{
    Console.WriteLine("Автор Самир ");
}
// Method1();



// Вид 2                 // // 2 группа метода, принимают, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст сообщения", 4);
// Method21(msg: "Текст сообщения",count: 4);

// Вид 3        Ничего не принимает, но возвращает
//  Если метод что то возвращает мы обязательно должны указать тип данных

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Вид 4   Что то принимает и возвращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;       // Empty озночает что result пустая сторка

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     } 
//     return result;
// }

// string res = Method4(10, "$");
// Console.Write(res);

string Method4(int count, string text)
{
    string result = String.Empty;       // Empty озночает что result пустая сторка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
        
    }
    Console.WriteLine();

}