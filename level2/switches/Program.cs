Console.WriteLine("What level are you?");

int employeeLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is your name?/");
string employeeName = Console.ReadLine();

string title= "";

switch(employeeLevel){
    case 100:
    title = "Junior Associate";
    break;
    case 200:
    title = "Senior Associate";
    break;
    case 300:
    title = "Manager";
    break;
    case 400:
    title = "Senior Manager";
    break;
 default:
    title = "Associate";
    break;
}


Console.WriteLine($"{employeeName}, {title}");