// See https://aka.ms/new-console-template for more information

/// <summary>
/// This program will be calculating the number of pizza's prices and display the total
/// </summary>
public class Program
{

    public static void Main(string[] args)
    {
        // The price per pizza
        double priceOfAPizza = 8.99;
        // The grand total
        double total = 0.00;
        // User's input of number of pizzas
        string userInput = "blank";
        // Key for the while loop
        bool key = true;

        Console.WriteLine("Hello, GitHub!");
        int userNumber = ValidateInput(userInput, key);

        // Convert the int to a double to calculate the total price for the number of
        // pizzas.
        total = priceOfAPizza * Convert.ToDouble(userNumber);
        Console.WriteLine("The grand total of the pizzas is " + total);
    }

    private static int ValidateInput(string userInput, bool key)
    {
        // If key is true then ask the user the same question, validate the text
        // if it is a integer until the text is accepted

        // The user's number once text is validated
        int userNumber = 0;
        while (key)
        {
            Console.WriteLine("How many pizzas would the user like?");
            userInput = Console.ReadLine();

            if (!IsTextValid(userInput) || IsInt(userInput) || IsWithinRange(Convert.ToInt32(userInput), 0, 100))
            {
                userNumber = Convert.ToInt32(userInput);
            }
            else
            {
                Console.WriteLine("You will need a integer number for this question, for example: 1, 6, 12");
            }
        }

        return userNumber;
    }

    private static bool IsTextValid(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) // Checks for white spacing or is empty
        {
            return true;
        }
        return false;
    }

    private static bool IsInt(string input)
    {
        try
        {
            Convert.ToInt32(input);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
        catch (OverflowException)
        {
            return false;
        }
    }

    private static bool IsWithinRange(int number, int minimum, int maximum)
    {
        if (number >= minimum && number <= maximum)
        {
            return true;
        }
        return false;
    }
}