Random number = new Random();

int current = number.Next(4 , 11);

// do {
//     current = number.Next(0, 11);
//     Console.WriteLine(current);
// } while(current != 7);

while (current >= 3){
     Console.WriteLine(current);
    current = number.Next(0, 11);

}
Console.WriteLine($"Last number {current}");