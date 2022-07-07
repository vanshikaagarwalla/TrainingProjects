using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Task
{ 
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
         public int Temperaturecelsius { get; set; }
          public string Summary { get; set; }
    }
    
    public class Employee
    {
        public int Id = 1;
        public string name = "John Smith";
        public string subject = "Physics";
    }
    public class Serializationdemo
    {
    // serialization - xm1
    public void JsonSerialize()
    {
        var WeatherForecast = new WeatherForecast
        {
            Date = DateTime.Parse("2019-08-01"),
            Temperaturecelsius = 25,
            Summary = "Hot"
        };

        string jsonString = JsonSerializer.Serialize(WeatherForecast);
        var obj = JsonSerializer. Deserialize<WeatherForecast>(jsonString);

        Console.WriteLine(obj.Date);
        Console.WriteLine(obj.Temperaturecelsius);
        Console.WriteLine(obj.Summary);
    }
        public void XmlSerialize()
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\vaagarwalla\Desktop\.net project\serialization.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();
        }
        public void XmlDeserialize()
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            StreamReader reader = new StreamReader(@"C:\Users\vaagarwalla\Desktop\.net project\serialization.xml");
            bs = (Employee)xs.Deserialize(reader);
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id:" + bs.Id);
            Console.WriteLine("Name:"+ bs.name);
            Console.WriteLine("Subject:"+bs.subject);

        }
    }
}
