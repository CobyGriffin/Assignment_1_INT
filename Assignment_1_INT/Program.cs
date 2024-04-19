using System.Security.Cryptography.X509Certificates;

namespace Assignment_1_INT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            part1();
           

            part2();
            //Samantha runs a small bakery. In one day, she bakes 5 batches of cookies, with each batch containing 24 cookies.
            // She sells each cookie for $2. At the end of the day, she gives away 10 cookies to her neighbors and had to throw away 8 cookies that were accidentally burnt.
            //How much money did Samantha make from selling the cookies after giving away and throwing away some of them?

           

        } //main 
        public static void part1()
        {
            double num1 = 6;
            int num2 = 2;
            int num3 = 4;
            int num4 = 8;
            int num5 = 10;
            double q1 = num1 + num2;
            double q2 = num1 - num2;
            int q3 = (num3 * num2) - num3;
            double q4 = (num1 / num3) - num1;
            int q5 = num3 + num3 - (num2 * num5);
            Console.WriteLine($"{num1} + {num2} = {q1}");
            Console.WriteLine($"{num1} - {num2} = {q2}");
            Console.WriteLine($"({num3} * {num2}) - {num3} = {q3}");
            Console.WriteLine($"({num1} / {num3}) - {num1} = {q4}");
            Console.WriteLine($"{num3} + {num3} - ({num2} * {num5}) = {q5}");
        }
       public static void part2()
        {
            int batch = 24;
            int cookie_cost = 2;
            int cookie_given = 10;
            int bad_cookie = 8;
            int q6 = (5 * batch - cookie_given - bad_cookie) * cookie_cost;
            Console.WriteLine($"({5} * {batch} - {cookie_given} - {bad_cookie}) * {cookie_cost} = {q6}");
        }
    } //Class
} //namespace