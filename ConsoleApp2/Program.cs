using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 1;
            double y = 1;
            double z = 1;
            int count = 0;
            List<double> values = new List<double>();
            double formula = ((1 / x) + (1 / y) + (1 / z));
            for (x = 1; x <= 100; x++)
            {
                for (y = 1; y <= 100; y++)
                {
                    for (z = 1; z <= 100; z++)
                    {
                        
                        formula = ((1 / x) + (1 / y) + (1 / z));
                        //var n = Math.Truncate(formula);
                        //Console.WriteLine(formula);
                        if (x != y && x !=z && z != y)
                        {
                            if (formula % 1 == 0)
                            {
                                if (values.Count<1)
                                {
                                    Console.WriteLine("x=" + x + "y=" + y + "z=" + z);
                                    Console.WriteLine(formula);
                                    count++;
                                }
                                
                                values.Add(x);
                                values.Add(y);
                                values.Add(z);

                                foreach (var item in values)
                                {

                                    if (!values.Contains(item))
                                    {
                                        Console.WriteLine("x=" + x + "y=" + y + "z=" + z);
                                        Console.WriteLine(formula);
                                        count++;
                                        //continue;
                                    }
                                }
                                

                                
                            }
                        }
                        
                    }
                }

            }
            Console.WriteLine(count + " kere var");


            Console.ReadKey();
        }
    }
}
