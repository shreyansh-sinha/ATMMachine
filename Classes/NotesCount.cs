namespace ATMMachine.Classes
{
    public class NotesCount
    {
        public long FiveHundredCount { get; set; }
        public long TwoHundredCount { get; set; }
        public long HundredCount { get; set; }

        public NotesCount(long fiveHundredCount, long twoHundredCount, long hundredCount)
        {
            FiveHundredCount = fiveHundredCount;
            TwoHundredCount = twoHundredCount;
            HundredCount = hundredCount;
        }
    }
}
