 // Напишите программу, которая принимает на вход трёхзначное число и 
 //на выходе показывает вторую цифру этого числа.
    //456 -> 5
    //782 -> 8
    //918 -> 1


    /*Random random = new Random ();

    int number = random.Next (100,1000);
    
    Console. WriteLine (number);

    
    int newNumber = (number % 100) /10;

    Console.WriteLine (newNumber);
    */

Console.WriteLine ("Введите трёхначное число");


bool isParsed = int.TryParse (Console.ReadLine (), out int number);
if (isParsed == false)
{
    Console.WriteLine ("Ошибка! Введите число!");
    return;
}
   
int newNumber = (number % 100) /10;

    Console.WriteLine (newNumber);
   