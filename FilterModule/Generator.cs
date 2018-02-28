using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class RecursiveFileProcessor 
{
    //public static void Main(string[] args) => ProcessDirectory("data");

    public static void ProcessDirectory(string targetDirectory) 
    {
        // Process the list of files found in the directory.
        string [] fileEntries = Directory.GetFiles(targetDirectory);
        foreach(string fileName in fileEntries)
            SelectFile(fileName);
    }

    public static Accelerometer ProcessFile(string file)
    {
        Accelerometer twirly = new Accelerometer();
        List<string> parsedData = new List<string>();

        using (StreamReader readFile = new StreamReader(file))
        {
            string line;
            string[] row;

            while ((line = readFile.ReadLine()) != null)
            {
                row = line.Split(',');
                //Console.WriteLine("Value: {0}",row.GetValue(0));
                twirly.xAxis=(float) Convert.ToDouble(row[0]);
                twirly.yAxis=(float) Convert.ToDouble(row[1]);
                return twirly;
            } 
            
        }
        return new Accelerometer();
    }

    public static void SelectFile(string path) 
    {
        Console.WriteLine("Selecting file {0}", path);
        ProcessFile(path);
    }
}
