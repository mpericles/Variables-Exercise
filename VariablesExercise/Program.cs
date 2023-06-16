namespace VariablesExercise
{
    public class Program
    {


        static void Main(string[] args)
        {
        
        // Declare and initialize variables //
        string Name = "Moxie";
        int months = 6;
        char firstlet = 'M';
        bool isabool = true;
        double anothernumber = 234.35;
        decimal lastnumber = 234.45m;

        Console.WriteLine($"My dog's name is {Name}, She is {months} months old");
        Console.WriteLine($"The first letter {firstlet} and it is {isabool}");
        Console.WriteLine($"The numbers are {anothernumber} and the proper decimal is {lastnumber}");
        Console.WriteLine("Hello, World!");

        }
    }
}
