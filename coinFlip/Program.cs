
Random coin = new Random();

int flip = coin.Next(0,10);

string headsOrTails = flip >=5? "heads" : "tails";

Console.WriteLine(headsOrTails);