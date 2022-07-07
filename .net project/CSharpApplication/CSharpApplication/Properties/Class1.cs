using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // File handling

namespace CSharpApplication.Properties
{
    internal class Class1
    {

        public void CreateMovie()
        {
            // Step 1 How to create file?
            FileStream fileStreamObj = new FileStream(@"C:\Users\vaagarwalla\Desktop\.net project\Class1.txt", FileMode.Create,FileAccess.Write);
            // step 2 how to write file
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            streamWriter.WriteLine("MovieId:123");
            streamWriter.WriteLine("MovieName:RRR");
            streamWriter.WriteLine("MovieDesc:Action");
            streamWriter.WriteLine("MovieLanguage:Telugu");
            streamWriter.Close(); // close writing operation
            fileStreamObj.Close(); // close file operation
            Console.WriteLine("File operation completed");
        }
    }
}
