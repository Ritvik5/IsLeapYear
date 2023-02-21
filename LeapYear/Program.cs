namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year>=1000 && year<=9999)
            {
                Console.WriteLine("The Given Input is Correct");
            }
            else
            {
                Console.WriteLine("Enter Valid year");
            }

            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year+ " is a Leap Year");
            }
            else
            {
                Console.WriteLine(year+ " is not a Leap Year");
            }
        }
    }
}