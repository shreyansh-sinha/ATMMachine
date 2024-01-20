namespace ATMMachine.Classes.AbstractHandler
{
    public abstract class PaymentProcessor
    {
        private PaymentProcessor _paymentProcessor;
        public PaymentProcessor(PaymentProcessor paymentProcessor)
        {
            this._paymentProcessor = paymentProcessor;
        }
        public virtual void handle(long amount, NotesCount notesCount)
        {
            if (_paymentProcessor != null)
                _paymentProcessor.handle(amount, notesCount);
        }
    }
}
