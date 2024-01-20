using ATMMachine.Classes.AbstractHandler;

namespace ATMMachine.Classes.ConcreteHandlers
{
    public class HundredProcessor : PaymentProcessor
    {

        public HundredProcessor(PaymentProcessor processor) : base(processor) { }
        public override void handle(long amount, NotesCount notesCount)
        {
            long notes = amount / 100;
            long hundredCount = notesCount.HundredCount;

            if (hundredCount > 0)
            {
                long notesNeeded = Math.Min(hundredCount, notes);
                notesCount.HundredCount -= notesNeeded;
                amount -= notesNeeded * 100;
                Console.WriteLine($"Returning {notesNeeded} 100 rupee notes");
                if (amount > 0)
                    base.handle(amount, notesCount);
            }
        }
    }
}
