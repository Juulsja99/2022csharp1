namespace TimeOpdracht
{
    internal class Program
    {
        public static void Main()
        {
           while(true) 
           {
                string time = DateTime.Now.ToString("h:mm:ss tt");
                Console.WriteLine("Het is nu {0}", time);
                Thread.Sleep(1000);
                Console.Clear();
           }
        }
    }
}