using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. File and Directory Operations in C#

            //string directoryPath = "MyTestDirectory";
            //string filePath = Path.Combine(directoryPath, "testfile.txt");

            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //}
            ////Creates directory if it doesn't exist.
            //File.WriteAllText(filePath, "Hello, C#");
            ////Creates and writes in file.
            //string fileContent = File.ReadAllText(filePath);
            //Console.WriteLine("File content: " + fileContent);
            ////Read and display contents of file.
            //File.Delete(filePath);
            //Directory.Delete(directoryPath);
            ////Deletes file and directory
            //Console.WriteLine("File and directory deleted successfully.");

            ////-----------------------------------------------------------------------------------////

            ////2. Stream-based I/O

            //string sourceFilePath = "sample.txt";
            //string destinationFilePath = "copy.txt";

            //using (StreamReader reader = new StreamReader(sourceFilePath))
            ////Opens a streamreader, closes automatically
            //using (StreamWriter writer = new StreamWriter(destinationFilePath))
            ////Opens a streamwriter, closes automatically
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        writer.WriteLine(line);
            //    }
            //    //Copies to copy file
            //}
            //Console.WriteLine("File copied successfully.");

            ////-----------------------------------------------------------------------------------////

            ////4. Exception Handling in File Operations

            //try
            //{
            //    string sourceFilePath = "sample.txt";
            //    string destinationFilePath = "copy.txt";

            //    using (StreamReader reader = new StreamReader(sourceFilePath))
            //    //Opens a streamreader, closes automatically
            //    using (StreamWriter writer = new StreamWriter(destinationFilePath))
            //    //Opens a streamwriter, closes automatically
            //    {
            //        string line;
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            writer.WriteLine(line);
            //        }
            //        //Copies to copy file
            //    }
            //    Console.WriteLine("File copied successfully.");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("File not found: " + ex.Message);
            //}
            //catch (UnauthorizedAccessException ex)
            //{
            //    Console.WriteLine("Unauthorized access: " + ex.Message);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("IO Exception: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred.");
            //    Console.WriteLine(ex.Message);
            //}

            ////-----------------------------------------------------------------------------------////

            ////5. File Search and Modification in Directory

            //string directoryPath = "Logs";
            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //    //Creates directory.
            //    string sampleFilePath = Path.Combine(directoryPath, "sample.txt");
            //    //Creates sample file.
            //    File.WriteAllText(sampleFilePath, "Sample log entry.");
            //    Console.WriteLine("Sample file created in Logs directory");
            //}

            //foreach (string filePath in Directory.GetFiles(directoryPath, "*.txt"))
            //{
            //    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //    File.AppendAllText(filePath, $"\n{timestamp}");
            //    //Adds timestamp at the end.
            //    string content = File.ReadAllText(filePath);
            //    Console.WriteLine($"File: {filePath}\nContent:\n{content}");
            //    //Displays all file contents.
            //}

            ////-----------------------------------------------------------------------------------////

            ////6. Binary File Operations with Streams

            //int[] numbers = { 3, 5, 2, 5, 6, 7 };
            //string filePath = "data.bin";

            //using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            //{
            //    foreach (int number in numbers)
            //    {
            //        writer.Write(number);
            //    }
            //    //Writes content.
            //}
            //Console.WriteLine("Data written.");
            //using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            //{
            //    Console.WriteLine("Reading data");
            //    while (reader.BaseStream.Position != reader.BaseStream.Length)
            //    {
            //        int number = reader.ReadInt32();
            //        Console.WriteLine(number);
            //    }
            //    //Reads and displays data.
            //}

            ////-----------------------------------------------------------------------------------////

            ////7. Custom Exception Handling in File Operations
            ////Question: Create a custom exception class named FileTooLargeException which is thrown when a file
            ////exceeds 1 MB in size.Write a program that reads a file's size and throws this exception if the file
            ////size is too large.Otherwise, it should display "File size is acceptable."

            //string filePath = "largefile.txt";
            //try
            //{
            //    FileInfo fileInfo = new FileInfo(filePath);
            //    if (fileInfo.Length > 1024 * 1024)
            //    //1 MB.
            //    {
            //        throw new FileTooLargeException("The file size exceeds 1 MB.");
            //    }
            //    //Throws custom exception if file size is greater than 1 MB.
            //    Console.WriteLine("File size is acceptable");
            //}
            //catch (FileTooLargeException ex)
            //{
            //    Console.WriteLine("Custom Exception: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception: " + ex.Message);
            //}

            ////-----------------------------------------------------------------------------------////









            Console.ReadLine();
            }
    }
}
