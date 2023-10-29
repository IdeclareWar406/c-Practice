// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#");

Random dice = new Random();
int roll = dice.Next(1,7);
    Console.WriteLine(roll);

Random money = new Random();

int amount = money.Next(0,300);

Console.WriteLine(amount);