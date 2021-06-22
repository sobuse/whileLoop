using System;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //var i = 0;
            //while (i <= 10)
            //{
            //    if(i % 2 == 0)
            //         Console.WriteLine(i);

            //    i++;
            //}

            //its better to use a while loop when you kwon how many times you are going to do iteration

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine( "@Echo: " + input);
            }
        }
    }
}
