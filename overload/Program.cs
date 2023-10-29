Random dice = new Random();

int rollOne = dice.Next();
int rollTwo = dice.Next(50);
int rollThree = dice.Next(51,101);
Console.WriteLine(rollOne);
Console.WriteLine(rollTwo);
Console.WriteLine(rollThree);


