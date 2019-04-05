using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_numbers
{
  public class limited
  {
     public static double Limiter(double x)
     {
         if (x < 0 || x > 100)
         {
             Console.WriteLine("Please ensure your value is from 0 to 100");
             x = double.Parse(Console.ReadLine());
         }
            return x;
     }

       public static double grades(double a, double b, double c, double d, double e, double f, double g, double h, double i, double j)
       {
           return (a + b + c + d + e + f + g + h + i + j); 
       }
  }
}


