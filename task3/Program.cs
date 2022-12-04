 // Напишите программу, которая принимает на вход цифру, 
 //обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
//7 -> да
//1 -> нет

/*Console.WriteLine ("Напишите цифру недели");


bool isParsed = int.TryParse (Console.ReadLine (), out int data);
if (isParsed == false)

{
    Console.WriteLine ("Ошибка! Введите число!");
    return;
}

if (data > 0 && data < 8)

{

if ( data == 1)
{
 Console.WriteLine ("нет");
}

if ( data == 2)
{
 Console.WriteLine ("нет");
}
if ( data == 3)
{
 Console.WriteLine ("нет");
}
if ( data == 4)
{
 Console.WriteLine ("нет");
}
if ( data == 5)
{
 Console.WriteLine ("нет");
}
if ( data == 6)
{
 Console.WriteLine ("Да, выходной!");
}
if ( data == 7)
{
 Console.WriteLine ("Да, выходной!");
}

}

 else

{
  Console.WriteLine ("Такого дня недели не существует!");
}
*/

Console.WriteLine ("Напишите цифру недели");

bool isParsed = false;
int data = 0;
while (isParsed == false)
{
    isParsed = int.TryParse (Console.ReadLine (), out data);
if (isParsed == false)
{
    Console.WriteLine ("Напишите цифры!");
}    
}
if (data > 0 && data < 8)

{

if ( data == 1)
{
 Console.WriteLine ("нет");
}

if ( data == 2)
{
 Console.WriteLine ("нет");
}
if ( data == 3)
{
 Console.WriteLine ("нет");
}
if ( data == 4)
{
 Console.WriteLine ("нет");
}
if ( data == 5)
{
 Console.WriteLine ("нет");
}
if ( data == 6)
{
 Console.WriteLine ("Да, выходной!");
}
if ( data == 7)
{
 Console.WriteLine ("Да, выходной!");
}

}

 else

{
  Console.WriteLine ("Такого дня недели не существует!");
}
