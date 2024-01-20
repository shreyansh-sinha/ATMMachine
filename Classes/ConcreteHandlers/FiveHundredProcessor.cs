using ATMMachine.Classes.AbstractHandler;

namespace ATMMachine.Classes.ConcreteHandlers
{
    public class FiveHundredProcessor : PaymentProcessor
    {

        public FiveHundredProcessor(PaymentProcessor processor) : base(processor) { }
        public override void handle(long amount, NotesCount notesCount)
        {
            long notes = amount / 500;
            long fiveHundredCount = notesCount.FiveHundredCount;

            if (fiveHundredCount > 0)
            {
                long notesNeeded = Math.Min(fiveHundredCount, notes);
                notesCount.FiveHundredCount -= notesNeeded;
                amount -= notesNeeded * 500;
                Console.WriteLine($"Returning {notesNeeded} 500 rupee notes");
                if (amount > 0)
                    base.handle(amount, notesCount);
            }
        }
    }
}
