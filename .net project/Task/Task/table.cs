using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task
{
    internal class table
    {
        public void createTable()
        {


            FileStream fs = new FileStream(@"C:\Users\vaagarwalla\Desktop\.net project\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fs);
            Console.WriteLine("Id\tsource \t\tDestination\tDate \tTime\t\tStatus\tNetwork");
            //Console.WriteLine(streamReader.ReadToEnd());
            while (streamReader.Peek() > 0)
            {
                //Console.WriteLine(streamReaderObj.ReadLine());

                string line = streamReader.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0]=="Date")
                    {
                        Console.Write(myStrs[1] + ":" + myStrs[2]+ ":" + myStrs[3].Remove(2)+"\t");
                    }
                    else
                    Console.Write(myStrs[1] +"\t");
                }
                else
                {
                    Console.WriteLine("\t");
                }


            }
            fs.Close();
            Console.ReadLine();
        }
    }
}
