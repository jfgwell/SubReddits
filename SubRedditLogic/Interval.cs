namespace SubRedditLogic
{
    public class Interval
    {
        private static System.Timers.Timer timer;
        private static SubRedditLogic redditLogic;

        public void Setup()
        {
            redditLogic = new SubRedditLogic();
            redditLogic.Setup();
        }
        public void Run()
        {
            Timer timer = new Timer(TimerCallback, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));


            // Keep the program running
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }


        private static void TimerCallback(object state)
        {
            // Call the Process() method at the specified interval
            redditLogic.Process();
        }
    }
}