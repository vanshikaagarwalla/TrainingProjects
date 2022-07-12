using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Customer
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public double Balance { get; set; }
    }
    public class Person
    {
        public void Handson()
        {
           /* Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            var result2 = (from d in str
                          group d by d into y
                          orderby y.Key descending
                          select y).Take(1).ToList();
            var result3 = (from d in result2
                           orderby d.Count() descending
                           select d).Take(1).ToList();

            var myResult = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
            Console.WriteLine("Frequent Character is "+ myResult);*/

           int[] numbers ={ 6, 0, 999, 11, 443, 6, 1, 24, 54 };
            var n = (from d in numbers
                    orderby d descending
                    select d).Take(5).ToList();
            foreach (var i in n)
            {
                Console.WriteLine(i);
            }
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var s = (from d in fruits
                     where d.StartsWith("L")
                     select d).ToList();
            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var s2 = (from d in mixedNumbers
                      where d%4==0 || d%6==0
                      select d).ToList();
            foreach(int i in s2)
            {
                Console.WriteLine(i);
            }
            List<int> num = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            
            int result = num.Count();
            Console.WriteLine("Total number of Elements: {0}", result);
            List<double> purchases = new List<double>()
          {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            double res = purchases.Sum();
            Console.WriteLine("Total Amount is : "+res);

            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            double m = prices.Max();
            Console.WriteLine("The Maximum Price is: " + m);



        }

        public void BankDetails()
        {
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var result2 = from d in customers
                          where d.Balance>1000000
                          group d.Bank by d.Bank into y
                          select y;
            foreach (var item in result2)
            {

                Console.WriteLine(item.);
            }
        }
    }
}
