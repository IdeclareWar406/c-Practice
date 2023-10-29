using System;

// initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();

string [] students = {"Sophia", "Andrew", "Emma", "Logan"};

int [] sophiaScore = {90,86,87,98,100};
int [] andrewScore = {92,89,81,96,90};
int [] emmaScore = {90,85,87,98,60};
int [] loganScore = {90,95,87,88,96};


foreach(string student in students){
    int studentTotal = 0;
    int studentAverage = 0;
    if(student == "Sophia"){
        foreach(int score in sophiaScore){
            studentTotal = studentTotal + score;
             studentAverage = studentTotal / sophiaScore.Length;
            
        }
    }
    else if(student == "Andrew"){
        foreach(int score in andrewScore){
            studentTotal = studentTotal + score;
            studentAverage = studentTotal / andrewScore.Length;
        }
    }
    else if(student == "Emma"){
        foreach(int score in emmaScore){
            studentTotal = studentTotal + score;
            studentAverage = studentTotal / emmaScore.Length;

        }
    }

    else if(student == "Logan"){
        foreach(int score in loganScore){
            studentTotal = studentTotal + score;
            studentAverage = studentTotal / loganScore.Length;
        }
    }

    if(studentAverage > 90){
        Console.WriteLine($"{student} has an A with {studentAverage}%");
    }
    else if((studentAverage >= 80) && (studentAverage <90)){
        Console.WriteLine($"{student} has an average of {studentAverage} which is a B");
    }
    else if((studentAverage >=70) && (studentAverage < 80)){
        Console.WriteLine($"{student} has an average of {studentAverage} which is a C");
    }
    else if((studentAverage >= 60)&& (studentAverage < 70)){
        Console.WriteLine($"{student} has an avearage of {studentAverage} which is a D");
    }
    else {
        Console.WriteLine($"{student} has an average of {studentAverage} which is failing");
    }
    
}