using System.Globalization;

//     Console.WriteLine("Please enter a number between 5 - 10");


// int [] numbers = {0,1,2,3,4,5,6,7,8,9};

// bool validEntry  = false;

// bool meetsParam = false;

// do {

//     int userInput = Convert.ToInt32(Console.ReadLine());

//     foreach(int number in numbers){
//         if(userInput == number){
//             validEntry = true;
//         }
//     }
//     if(validEntry){
//         if(userInput >= 5 && userInput <= 10){
//             meetsParam = true;
//         }
//     }
    
// } while(meetsParam == false);

// if(meetsParam){
//     Console.WriteLine("Your response has been recorded");
// }

// Console.WriteLine("Enter your position, Admin, Manager, or User");

// string position = "admin|manager|user";

// bool validEntry = false;

// do {
//     string userPosition = Console.ReadLine();
//     string checkedPos = userPosition.Trim().ToLower();
//     if(position.Contains(checkedPos)){
//         validEntry = true;
        
//     }
//     else {
//         Console.WriteLine("Please input a valid entry");
//     }

// } while(!validEntry);

// if(validEntry){
//     Console.WriteLine("Thanks for your input");
// }

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

string myString ="";

int periodLocation = 0;

for (int i = 0;i < myStrings.Length; i++){
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    string mySentance = "";
    while(periodLocation != -1){
      
        mySentance = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        periodLocation = myString.IndexOf(".");
        Console.WriteLine(mySentance);
    }
    mySentance = myString.Trim();
    Console.WriteLine(mySentance);
}