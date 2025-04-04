namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Target Year:");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Target Month:");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Target Day:");
            int Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Target Hour:");
            int Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Target Minutes:");
            string Minutes = Console.ReadLine();

            int Minutes1 = Convert.ToInt32(Minutes[0]);
            int Minutes2 = Convert.ToInt32(Minutes[1]);
            int Minutes3 = Convert.ToInt32(Minutes);
            DateTime current = DateTime.Now;
            DateTime Target = new DateTime(Year, Month, Day, Hour, Minutes3, 0);

            TimeSpan Difference = Target - current;

            //.WriteLine(Target);
            Console.WriteLine($"Hours Left: {Difference.ToString("h")}, Minutes Left: {Difference.ToString("mm")}, Seconds Left: {Difference.ToString("ss")}");
        }
    }
}
