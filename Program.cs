using ATMMachine.Classes;
using ATMMachine.Classes.ConcreteHandlers;
public class Program
{
    public static void Main(String[] args)
    {

        Console.WriteLine("Enter the amount to withdraw");
        long amount = Int64.Parse(Console.ReadLine());

        var notesCount = new NotesCount(10, 10, 10);
        long atmBalance = CalculateAtmBalance(notesCount);
        var paymentProcessor = new FiveHundredProcessor(new TwoHundredProcessor(new HundredProcessor(null)));

        if (amount % 100 != 0)
        {
            Console.WriteLine("Available denominations are 100, 200, 500 only !!");
        }
        else if (amount > atmBalance)
        {
            Console.WriteLine("Amount to be withdrawn is less than atm balance");
        }
        else
        {
            paymentProcessor.handle(amount, notesCount);
        }
    }

    private static long CalculateAtmBalance(NotesCount notesCount)
    {
        long fiveHundredCount = notesCount.FiveHundredCount;
        long twoHundredCount = notesCount.TwoHundredCount;
        long hundredCount = notesCount.HundredCount;

        long balance = 500 * fiveHundredCount + twoHundredCount * 200 + hundredCount * 100;
        return balance;
    }
}