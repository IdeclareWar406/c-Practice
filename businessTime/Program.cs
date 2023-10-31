using System.ComponentModel;

Console.WriteLine("State permission level");

string permission = Console.ReadLine();
Console.WriteLine("what is your level");
int level = Convert.ToInt32(Console.ReadLine()) ;

if(permission.Contains("Admin") && level > 55){
    Console.WriteLine("Welcome, Super Admin user.");
}

else if(permission.Contains("Admin") && level <= 55){
    Console.WriteLine("Welcome, Admin user");
}

else if(permission.Contains("Manager") && level >= 20){
    Console.WriteLine("Contact Admin for access");

}
else if(permission.Contains("Manager") && level < 20){
    Console.WriteLine("you do not have suffiecent prividelges");

}
else if(!permission.Contains("Admin|Manager")){
    Console.WriteLine("you do not have the privledge");
}