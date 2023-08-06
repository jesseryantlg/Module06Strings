using System; 
namespace Strings; 

internal class Program
{
    private static void Main(string[] args)
    {
        //First Exercise
        //string Welcome = "Welcome to ";
        //string CourseName = "CS132";
        //string message = Welcome + CourseName;
        //Console.WriteLine(message);

        //Second Exercise
        // string Welcome = "Welcome to ";
        // string CourseName = "CS132"; 
        // string message1 = string.Concat(Welcome, CourseName); //concatenate using concat() - a built-in method
        // string message2 = $"Prnting the strings for a second time: {Welcome} {CourseName}";

        // Console.WriteLine(message1);
        // Console.WriteLine(message2);

        //Third Exercise
        // string Welcome = "Welcome to ";
        // string CourseName = "CS132"; 
        // string message = Welcome.ToUpper() + CourseName.ToLower();
        // Console.WriteLine(message);

        //Fourth Exercise
        // string Welcome = "Welcome to "; 
        // string CourseName = "CS132";
        // string message1 = string.Concat(Welcome, CourseName); 
        // Console.WriteLine(message1.Length);

        //Fifth Exercise
        // string Welcome = "Welcome to ";
        // string CourseName = "CS132"; 
        // Console.WriteLine(Welcome[0]); //print the character at index [0] which is "W"
        // Console.WriteLine(CourseName.Substring(CourseName.Length - 1)); //get and print the last character of the string "CourseName"

        //Sixth Exercise
        string Welcome = "Welcome to "; 
        string CourseName = "CS132"; 
        string message = Welcome + CourseName;


        //the index starts at 0 and keeps iterating as long as it is in the range of "message"
        for (int i = 0; i < message.Length; i++)
        {
            if (i % 2 == 0)
            {
            Console.WriteLine(message[i]); //prints the value of "message" starting at index 0
            }
            
        }
    }

}