/*

4. Multithreading File Processor
Concepts: Threads, Lock, File Handling Task:
Create threads to read 3 large files in parallel
Use Thread.Join() to ensure all are read
Count total lines across all files.

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assignment_31_05_2025
{
    internal class Program4
    {
        static int totalLineCount = 0;
        static object lockObj = new object();

        static void Main()
        {
            string[] filePaths =
            {
                "file1.txt",
                "file2.txt",
                "file3.txt"
            };

            Thread[] threads = new Thread[filePaths.Length];

            for (int i = 0; i<filePaths.Length; i++)
            {
                string path = filePaths[i];
                threads[i] = new Thread(() => CountLines(path));
                threads[i].Start();
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }
            Console.WriteLine($"\nTotal lines across all files:{totalLineCount}");
        }

        static void CountLines(string filePath)
        {
            try
            {
                int lineCount = 0;

                using (var reader = new StreamReader(filePath))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                lock (lockObj)
                {
                    totalLineCount += lineCount;
                }
                Console.WriteLine($"{Path.GetFileName(filePath)}:{lineCount} lines");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading {filePath}:{ex.Message}");
            }
        }
    }
}
