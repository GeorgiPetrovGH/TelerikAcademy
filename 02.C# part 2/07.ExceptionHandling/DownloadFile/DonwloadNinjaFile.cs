/*
Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 */

using System;
using System.Net;
class DonwloadNinjaFile
{
    static void Main()
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "ninjaImageFile.jpg");
                Console.WriteLine("The image has been successfully downloaded.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter must not be null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error downloading file!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method DownloadFile() cannot be called simultaneously on multiple threads.");
            }
        }
    }
}

