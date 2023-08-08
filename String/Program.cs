using System; 
namespace Strings; 

internal class Program
{
    public static void Main()
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

        // //Sixth Exercise
        // string Welcome = "Welcome to "; 
        // string CourseName = "CS132"; 
        // string message = Welcome + CourseName;


        // //the index starts at 0 and keeps iterating as long as it is in the range of "message"
        // for (int i = 0; i < message.Length; i++)
        // {
        //     if (i % 2 == 0)
        //     {
        //     Console.WriteLine(message[i]); //prints the value of "message" starting at index 0
        //     }
            
        // }
        //PE06 NUMOUTTEST
        // double number = 987654.321d;
        // Console.WriteLine(number.ToString());
        // Console.WriteLine(number.ToString(".00")); 
        // Console.WriteLine(number.ToString("0"));
        // Console.WriteLine(number.ToString("C"));

        //MailStringTest
        // string user1 = NewEmail("Jesse", "Ryan"); 
        // string user2 = NewEmail("Bill", "Gates");
        // string user3 = NewEmail("Linus", "Torvalds"); 

        // Console.WriteLine(user1);
        // Console.WriteLine(user2);
        // Console.WriteLine(user3); 
        bool match1 = CompareStrings("Hello", "hello");
        bool match2 = CompareStrings("Jesse", "Ryan");

        if (match1)
        {
            Console.WriteLine("Option 1: These strings match");
        }
        else 
        {
            Console.WriteLine("Option 1: These strings do not match."); 
        }
        if (match2)
        {
            Console.WriteLine("Option 2: These strings match.");
        }
        else
        {
            Console.WriteLine("Option 2: These strings do not match"); 
        }
    }
    //CompareStrings Method
    public static bool CompareStrings(string s1, string s2)
    {
        return string.Equals(s1.ToUpper(), s2.ToUpper());
    }
    //MailStringTest Method
    // public static string NewEmail(string firstName, string lastName)
    // {
    //     string email = $"{char.ToLower(firstName[0])}{lastName.Substring(0, Math.Min(3, lastName.Length)).ToLower()}@abc.com";
    //     return email;  
    // }
}