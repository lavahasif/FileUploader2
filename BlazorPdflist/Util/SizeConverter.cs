using System;
using System.IO;

namespace BlazorPdflist.Util
{
    public static class FileSizeFormatter
    {
        // Load all suffixes in an array  
        static readonly string[] suffixes =
        { "Bytes", "KB", "MB", "GB", "TB", "PB" };
        public static string FormatSize(Int64 bytes)
        {
            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);
        }
    }
    //static void Main(string[] args)
    //{
    //    // Full file name  
    //    string fileName = @"C:\Temp\OK.zip";
    //    FileInfo fi = new FileInfo(fileName);

    //    if (fi.Exists)
    //    {
    //        string size = FileSizeFormatter.FormatSize(fi.Length);
    //        Console.WriteLine(size);
    //    }
    //    Console.ReadKey();
    //}
}  

