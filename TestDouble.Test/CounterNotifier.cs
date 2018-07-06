namespace TestDouble.Test
{
    public class CounterNotifier : INotifier
    {
        public int CallCount { get; private set; }

        public void Notify(User userToNotify)
        {
            CallCount++;
        }
    }
}
