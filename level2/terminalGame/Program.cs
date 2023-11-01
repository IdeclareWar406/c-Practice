int heroHealth = 50;
int monsterHealth = 50;
Random dice = new Random();
Random number = new Random();

int damage = number.Next(1,25);


while (heroHealth > 0 && monsterHealth > 0){
    int chance = dice.Next(0 , 10);
    Console.WriteLine($"chance {chance}");
    if(chance > 5) continue;

    monsterHealth = monsterHealth - damage;
    
    if(monsterHealth < 0) monsterHealth = 0;
    if(heroHealth < 0) heroHealth = 0;
    if(monsterHealth <= 0){
        Console.WriteLine($"The monstor has {monsterHealth} remaining. Player did {damage} to the monster. Player health is {heroHealth}");
        Console.WriteLine("Player wins");
        break;
    }
    else if(heroHealth <=0){
        Console.WriteLine($"The monstor has {monsterHealth} remaining. Player did {damage} to the monster. Player health is {heroHealth}");
        Console.WriteLine("Monster wins");
        
        break ;
    }
   
     heroHealth = heroHealth - damage;
    
    damage = number.Next(1, 30);
}
