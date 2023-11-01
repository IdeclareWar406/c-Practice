int heroHealth = 100;
int monsterHealth = 50;

Random number = new Random();

int damage = number.Next(1,25);


while (heroHealth > 0 && monsterHealth > 0){
    monsterHealth = monsterHealth - damage;
    heroHealth = heroHealth - damage;
    if(monsterHealth < 0) monsterHealth = 0;
    if(heroHealth < 0) heroHealth = 0;
    Console.WriteLine($"The monstor has {monsterHealth} remaining. Player did {damage} to the monster. Player health is {heroHealth}");
    damage = number.Next(1, 30);
}
