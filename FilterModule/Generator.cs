namespace FilterModule
{
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

public class RecursiveFileProcessor 
{
    

    public static void ProcessDirectory(string targetDirectory) 
    {
        // Process the list of files found in the directory.
        string [] fileEntries = Directory.GetFiles("..\\"+targetDirectory);
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
                Console.WriteLine("Values: {0} {1}",row.GetValue(0),row.GetValue(1));
                Console.WriteLine("File length: {0}",file.Length);
                var fileName = file.Substring(8,(file.Length - 12));
                var newFileName = fileName.Replace('.', ' ');
                var format = "yyyy MM dd HH mm ss";
                Console.WriteLine("formatdate: {0}",format);
                
                // twirly.fileTS = DateTime.Parse(newFileName);
                twirly.fileTS = DateTime.ParseExact(newFileName, format, CultureInfo.InvariantCulture);
                twirly.xAxis = (float) Convert.ToDouble(row[0]);
                twirly.yAxis = (float) Convert.ToDouble(row[1]);
                Console.WriteLine("Twirly Dates: {0}",twirly.fileTS);
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
}
