// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine ("Введите число");

bool isParsed = false;
int number = 0;
while (isParsed == false)
{
    isParsed = int.TryParse (Console.ReadLine (), out number);

if (isParsed == false)

{
    Console.WriteLine ("Ошибка! Введите цифры!");
} 
}

int result = 0;



if (number >= 100)
{
    while (number  > 999)
    {
        number = number/10;
    }

    result = number % 10;

Console.WriteLine (result);
}


else 
{
    Console.WriteLine ("Третьего числа не существует");
}


