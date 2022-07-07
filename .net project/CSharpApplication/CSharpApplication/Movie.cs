using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpApplication
{
    internal class Movie
    {
        public void CreateMovie()
        {
            // Step 1 How to create file?
            FileStream fileStreamObj = new FileStream(@"C:\Users\vaagarwalla\Desktop\.net project\Class1.txt", FileMode.Create, FileAccess.Write);
            // step 2 how to write file
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            string Name= Console.ReadLine();
            streamWriter.WriteLine("Movie name:  "+Name);
            int movieId = Convert.ToInt32(Console.ReadLine());
            streamWriter.WriteLine("Movie Id: "+movieId);
            string movieDesc = Console.ReadLine();
            streamWriter.WriteLine("Movie Desc: "+ movieDesc);
            string movieLanguage= Console.ReadLine();
            streamWriter.WriteLine("Movie Language: "+ movieLanguage);

            streamWriter.WriteLine("MovieId:123");
            streamWriter.WriteLine("MovieName:RRR");
            streamWriter.WriteLine("MovieDesc:Action");
            streamWriter.WriteLine("MovieLanguage:Telugu");
            streamWriter.Close(); // close writing operation
            fileStreamObj.Close(); // close file operation
            Console.WriteLine("File operation completed");
        }
          

        public void SelectMovie()
        {
            FileStream fileStream = new FileStream(@"C:\Users\vaagarwalla\Desktop\.net project\Class1.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
           /* Console.WriteLine(streamReaderObj.ReadLine());
            Console.WriteLine(streamReaderObj.ReadLine());
            Console.WriteLine(streamReaderObj.ReadLine());
            Console.WriteLine(streamReaderObj.ReadLine()); */
            while(streamReaderObj.Peek() >0)
            {
                //Console.WriteLine(streamReaderObj.ReadLine());
                string line = streamReaderObj.ReadLine();
                string[] myStrs = line.Split(':');
                Console.WriteLine(myStrs[1]);

            } 
            //Console.WriteLine(streamReaderObj.ReadToEnd());
            fileStream.Close();
        }
    }
}
