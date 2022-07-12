using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class PracticeQues
    {
        public void Practice()
        {
            /* 1.  int[] array = {1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
              var result = from d in array
                           where d < 0
                           select d;
                  foreach (var item in result)
                  {
                      Console.WriteLine(item);
                  }

              2. int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
              Console.WriteLine("The number and the Frequency are :");
              var result2 = from d in arr1
                            group d by d into y
                            select y;
              foreach (var item in result2)
              {

                  Console.WriteLine("Number "+ item.Key+" appears " + item.Count() +" times");
              }
            
           3. Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            var result3 = from d in str
                          group d by d into y
                          select y;
            foreach (var item in result3)
            {
                Console.WriteLine("Character " + item.Key + " : " + item.Count());
            } */

            List<string> list = new List<string>()
            {
               "ROME","LONDON","NAIROBI ","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS",
            };
            
            var result4 = from d in list
                          where d.StartsWith("A") && d.EndsWith("M")
                          select d;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
