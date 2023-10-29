using System.Runtime.CompilerServices;

string [] things = {"b123", "arc456","yurty67","8790bg","123yrts", "opys45","9087un","ayth65"};

Console.WriteLine(things.Length);


foreach(string item in things){
    if(item.StartsWith("b") ){
        
        Console.WriteLine(item);
    }


}