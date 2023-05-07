
//List<string> firstNames = new List<string>();

//firstNames.Add("Valentine");
//firstNames.Add("Precious");
//firstNames.Add("Atarah");

//foreach (string name in firstNames)
//{
//    Console.WriteLine(name);
//}

using System;
using System.Runtime.CompilerServices;

List<string> names = new List<string>();
string studentName;
string shouldContinue;
Console.WriteLine($"Welcome to the registration App." );
Console.WriteLine("Please enter the first names of all present students and when done type end or simply enter with no name ");
Console.Write("Name of present student 1 : ? ");
studentName = Console.ReadLine();
int studentNumbers = 2;
bool isValidInput = true;

if (studentName == "")
{
    Console.WriteLine("You pressed enter and this terminates the program before you enter any names. Thanks Bye");
    isValidInput = false;
}
else if (studentName == "end")
{
    Console.WriteLine("You typed end and this terminates the program before you enter any names. Thanks Bye");
    isValidInput = false;
}

else
{
    isValidInput = true;
    do
    {
        names.Add(studentName);
        Console.Write($"Name of present student: {studentNumbers} : ? ");
        studentName = Console.ReadLine();
        studentNumbers++;

        if (studentName == "" )
        {
            Console.WriteLine("Thanks for entering the names of present students. Now that pressed enter please see below : ");
            isValidInput= false;
        }
        else if (studentName == "end")
        {
            Console.WriteLine("Thanks for entering the names of present students. Now that you typed end please see below : ");
            isValidInput = false;
        }

    } while (isValidInput);


    Console.WriteLine($"The number of student is {names.Count}");
    Console.Write("Do you want to see which names you have entered? : Type Yes/No : ");
    shouldContinue = Console.ReadLine();
    if (shouldContinue == "y" || shouldContinue == "yes")
    {
        Console.WriteLine($"The names of the students are the following : ");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    else
    {
        Console.WriteLine("Bye");
    }
}


    




