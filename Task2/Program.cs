
namespace Task2
{


    public static class Program
    {
        public static void Main()
        {

            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case (int)Months.January:
                    Console.WriteLine("January is a Winter Month");
                    break;
                case (int)Months.February:
                    Console.WriteLine("February is a Winter Month");
                    break;
                case (int)Months.March:
                    Console.WriteLine("March is a Spring Month");
                    break;
                case (int)Months.April:
                    Console.WriteLine("April is a Spring Month");
                    break;
                case (int)Months.May:
                    Console.WriteLine("May is a Spring Month");
                    break;
                case (int)Months.June:
                    Console.WriteLine("June is a Summer Month");
                    break;
                case (int)Months.July:
                    Console.WriteLine("July is a Summer Month");
                    break;
                case (int)Months.August:
                    Console.WriteLine("August is a Summer Month");
                    break;
                case (int)Months.September:
                    Console.WriteLine("September is an Autumn Month");
                    break;
                case (int)Months.October:
                    Console.WriteLine("October is an Autumn Month");
                    break;
                case (int)Months.November:
                    Console.WriteLine("November is an Autumn Month");
                    break;
                case (int)Months.December:
                    Console.WriteLine("December is a Winter Month");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;

            }

        }
    }

}
