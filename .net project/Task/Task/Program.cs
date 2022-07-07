using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.JsonSerialize();
           // p.XmlSerialize();
          //  p.XmlDeserialize();
           // GenericsDemo genericsDemo = new GenericsDemo();
          //  genericsDemo.ShowSalaryReport(400.20);
           // genericsDemo.ShowAgeReport(30); 
            //genericsDemo.ShowGenderReport("Male");
           // table t = new table();
            //t.createTable();
          //  Serializationdemo serializationdemo = new Serializationdemo();
           // serializationdemo.XmlSerialize();
            //serializationdemo.XmlDeserialize();
            //serializationdemo.JsonSerialize();

            Console.ReadLine();
        }
    }
}

