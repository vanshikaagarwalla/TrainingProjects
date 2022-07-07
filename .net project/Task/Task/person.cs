using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task
{
    public class Details
    {
        public int Age;
        public string Name;
        public string City;
    }
    public class Details1
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    public class person
    {
        public void JsonSerialize()
        {
            var Details1 = new Details1()
            {
                Age = Convert.ToInt32(Console.ReadLine()),
                Name = Console.ReadLine(),
                City = Console.ReadLine()

            };

            string jsonString = JsonSerializer.Serialize(Details1);
            var obj = JsonSerializer.Deserialize<Details1>(jsonString);

            Console.WriteLine(obj.Age);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.City);
        }
        public void XmlSerialize()
        {
            Details bs = new Details();
            bs.Age=Convert.ToInt32(Console.ReadLine());
            bs.Name=Console.ReadLine();
            bs.City=Console.ReadLine();
            XmlSerializer xs = new XmlSerializer(typeof(Details));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\vaagarwalla\Desktop\.net project\person.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();
        }
        public void XmlDeserialize()
        {
            Details bs = new Details();
            XmlSerializer xs = new XmlSerializer(typeof(Details));
            StreamReader reader = new StreamReader(@"C:\Users\vaagarwalla\Desktop\.net project\person.xml");
            bs=(Details) xs.Deserialize(reader);
            Console.WriteLine("Age: " + bs.Age);
            Console.WriteLine("Name:" + bs.Name);
            Console.WriteLine("City:" + bs.City);

        }
    }
}
