using System.IO;

namespace System.iodemo.writer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string myName = Console.ReadLine();
            Console.WriteLine("Enter your address: ");
            string myAddress = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int myAge = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\NotePad\\Assign2.3.1.txt");
                //Write a line of text
                sw.WriteLine("My name is: " + myName);
                //Write a second line of text
                sw.WriteLine("My address is: " + myAddress);
                //Write a second line of text
                sw.WriteLine("My age is: " + myAge);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue.");

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\NotePad\\Assign2.3.1.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
