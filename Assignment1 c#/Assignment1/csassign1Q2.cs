using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csassign2Q1
{
    internal class csassign1Q2
    {
       
        
            public static void main()
            {
                try
                {
                    int[] marks = new int[5];
                    int sum = 0;
                    float average;
                    int highest = 0;
                    Console.WriteLine("Enetr Marks:");
                    for (int i = 0; i < marks.Length; i++)
                    {
                        marks[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < marks.Length; i++)
                    {
                        sum += marks[i];
                        if (marks[i] > highest)
                        {
                            highest = marks[i];
                        }
                    }
                    average = sum / 5;
                    Console.WriteLine("Average = (0) Highest(1)", average, highest);

                }
                catch (Exception Error)
                {
                    Console.WriteLine(Error.ToString());
                }
                finally
                {
                    Console.WriteLine("Final");
                }
                Console.ReadLine();

            }

        
    }
}

