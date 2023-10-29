Random dice = new Random();

    int rollOne = dice.Next(1,7);
    int rollTwo = dice.Next(1,7);
    int rollThree = dice.Next(1,7);

    int total = rollOne + rollTwo + rollThree;

    if(total >= 15){
        Console.WriteLine("you lost");
    }

    else{
        Console.WriteLine("You win");
    }

