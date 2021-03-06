﻿namespace DirectoryTraversal
{
    using System;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            string path = "C:\\WINDOWS";
            string fileSearchPattern = "*.exe";

            TraverseDirectories(path, fileSearchPattern);
        }

        private static void TraverseDirectories(string path, string fileExtension = "*.exe")
        {
            try
            {
                ShowFiles(path, fileExtension);

                string[] directoryNames = Directory.GetDirectories(path);
                foreach (var dirName in directoryNames)
                {
                    TraverseDirectories(dirName);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ShowFiles(string path, string fileExtension)
        {
            var files = Directory.GetFiles(path, fileExtension);
            foreach (var fileName in files)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}
