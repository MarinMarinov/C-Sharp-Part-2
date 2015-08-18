//Problem 9. Delete odd lines
//
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader sr = new StreamReader(@"..\..\test.txt"))
            {
                string line;
                int counter = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    counter++;

                    if ((counter % 2) == 0) // check if odd
                    {
                        sw.WriteLine(line);
                    }
                }
            }
        }

        // uncoment for deleting the odd raws from the same file

        //using (StreamWriter sw = new StreamWriter(@"..\..\test.txt"))
        //{
        //    using (StreamReader sr = new StreamReader(@"..\..\output.txt"))
        //    {
        //        string line;

        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            sw.WriteLine(line);
        //        }
        //    }
        //}
    }
}