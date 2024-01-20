using ATMMachine.Classes.AbstractHandler;

namespace ATMMachine.Classes.ConcreteHandlers
{
    public class TwoHundredProcessor : PaymentProcessor
    {

        public TwoHundredProcessor(PaymentProcessor processor) : base(processor) { }
        public override void handle(long amount, NotesCount notesCount)
        {

            long notes = amount / 200;
            long twoHundredCount = notesCount.TwoHundredCount;

            if (twoHundredCount > 0)
            {
                long notesNeeded = Math.Min(twoHundredCount, notes);
                notesCount.TwoHundredCount -= notesNeeded;
                amount -= notesNeeded * 200;
                Console.WriteLine($"Returning {notesNeeded} 200 rupee notes");
                if (amount > 0)
                    base.handle(amount, notesCount);
            }
        }
    }
}
