using PDA.Algorithms;

internal class Program
{
    public static void Main(string[] args)
    {
        IAlgorithm algorithm;
        string? input;
        int choice;
        Console.WriteLine("press 0 = balance symbols, press 1 = palindrome");

        choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input string: ");

        input = Console.ReadLine();

        if (choice == 0)
        {
            algorithm = new BalanceSymbolAlgorithm();
            
        }
        else
        {
            algorithm = new PalindromeAlgorithm();
        }

        var checker = algorithm.CheckInput(input!);

        if (checker)
        {
            Console.WriteLine($"Input \"{input}\" is valid");
        }
        else
        {
            Console.WriteLine($"Input \"{input}\" is NOT valid");
        }
    }
}