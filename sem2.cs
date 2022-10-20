//Задача 10: Напишите программу, 
//которая принимает на вход трёхзначное число и на
//выходе показывает вторую цифру этого числа.
/*
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot*10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} id {newNum}");
*/

//N13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
/*Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void TretCifra(int num)
{
    //int anyNumber = Convert.ToInt32(Console.ReadLine());
    string NumberText = Convert.ToString(num);
    if (NumberText.Length > 2)
    {
    Console.WriteLine("третья цифра: " + NumberText[2]);
    }
    else 
    {
    Console.WriteLine("третьей цифры нет");
    }
}
TretCifra(num);
*/

//второй вариант второй задачи
/*
Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
void tretcifra(int numb)
{
    while (100<numb && numb<1000)
    {
        numb=numb%10;
        Console.WriteLine(numb);
    }
    if (numb<100)
        Console.WriteLine("Третьей цифры нет");
}    
tretcifra(numb);
*/
//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void DenNedeli (int num)
{
    if (num == 7 || num == 6)
    {
        Console.WriteLine("Этот день выходной.");
    } 
    else
        if (num >= 1 &&  num < 6 )
        {
            Console.WriteLine("Это будний день.");
        }
    else
    {
        Console.WriteLine("Введенная цифра не является днем недели.");
    }
}
DenNedeli(num);    
*/