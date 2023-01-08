namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNums comp1 = new ComplexNums(7, 8);
            ComplexNums comp2 = new ComplexNums(5, 6);

            ComplexNums comp3 = comp1 + comp2;
            comp3.Show();

            ComplexNums comp4 = comp1 - comp2;
            comp4.Show();


            if (comp1 > comp2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (comp1 == comp2)
            {
                Console.WriteLine("Condition is true");
            }

            else
            {
                Console.WriteLine("Condition is false");
            }

            if (comp1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            var result = comp1 | comp2;

            if (result)
            {
                result.Show();
            }
            else
            {
                Console.WriteLine("Try again");
            }

            var result1 = comp1 | comp2;

            if (result1)
            {
                result1.Show();
            }
            else
            {
                Console.WriteLine("Try again");
            }

            string value = (string)comp1;

            Console.WriteLine(value);
        }
    }
}