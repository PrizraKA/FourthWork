namespace FourthWork
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 //
            Order order = new Order();
            order.InfoOfPeople();


            Console.WriteLine();
            Console.WriteLine();

            // 2 //
            Price price = new Price();
            price.Method();


            // 3 //
            Console.WriteLine("Enter the first side:");
            double firstSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second side:");
            double secondSide = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            double area = rectangle.AreaCalculator(firstSide, secondSide);
            double per = rectangle.PerimeterCalculator(firstSide, secondSide);
            Console.WriteLine($"Your numbers is: {firstSide} and {secondSide}\nArea is: {area}\nPerimeter is: {per}");

            // 4 //

            int firstnumber = new Random().Next(1, 100);
            int secondnumber = new Random().Next(1, 100);
            int thirdnumber = new Random().Next(1, 100);

            TheSmallestNumber smallestnumber = new TheSmallestNumber();
            smallestnumber.SmallestNumber(firstnumber, secondnumber, thirdnumber);
        }
    }
}