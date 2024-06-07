using System.Security.Cryptography.X509Certificates;

class Calculator
{
    static void Main(string[] args)
    {
    Console.WriteLine("This program performs division with whole numbers.");
        Console.Write("Please enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Please enter the second number: ");
            string input2 = Console.ReadLine();
        

        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            int result = number1/number2;
            Console.WriteLine($"\nThe result of {number1} divided by {number2} is {result}");
        }
        catch(FormatException)
        {
            Console.WriteLine("Input must be a whole number! Please try again.");
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Input can not be zero! Please try again.");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Input can not exceed two billion! Please try again.");
        }
        catch(Exception)
        {
            Console.WriteLine("Input must be a whole number! Please try again.");
        }
        finally
        { 
            Console.Write("Press any key to exit ");
            Console.ReadKey();
        };
        

    }
}