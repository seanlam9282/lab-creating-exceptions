using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_creating_exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle positiveCircle = new Circle(10);
            Circle negativeCircle = new Circle(-10);
            Circle zeroCircle = new Circle(0);

            try
            {
                positiveCircle.SetRadius();
                Console.WriteLine(positiveCircle.ToString()); 
            }
            catch
            {
                Console.WriteLine("Radius should be greater than 0.");
            }
            Console.WriteLine();

            try
            {
                negativeCircle.SetRadius();
                Console.WriteLine(negativeCircle.ToString());
            }
            catch
            {
                Console.WriteLine("Radius should be greater than 0.");
            }
            Console.WriteLine();

            try
            {
                zeroCircle.SetRadius();
                Console.WriteLine(zeroCircle.ToString());
            }
            catch
            {
                Console.WriteLine("Radius should be greater than 0.");
            }

            Console.ReadKey();
        }
    }
}
