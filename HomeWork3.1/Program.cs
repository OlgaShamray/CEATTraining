// using System;

Console.WriteLine("Olha Shamray HOMEWORK 3.1 - GAME");

string? userNumber;
string? yesno;
int minValue = 1, maxValue = 5;

do
{
    string randomNumber = Convert.ToString(new Random().Next(minValue, maxValue));

    Console.WriteLine($"Hi! Guess the number between {minValue} and {maxValue}");

    while ((userNumber = Console.ReadLine()) != randomNumber)
    {
        Console.WriteLine($"It is not {userNumber}, try again!");
    }
    Console.WriteLine($"Yes, the number is {randomNumber}!");
    Console.WriteLine("Enter 'y' if you want to play again");
    yesno = Console.ReadLine();

} while (yesno == "y");
Console.WriteLine("Good bye!");