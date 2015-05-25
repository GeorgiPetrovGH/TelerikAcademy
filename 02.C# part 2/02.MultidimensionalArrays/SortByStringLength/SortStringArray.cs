/*
Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/

using System;
class SortStringArray
{
    static string[] dinosaurs = {"Pachycephalosaurus", 
                              "Amargasaurus", 
                              "Tyrannosaurus", 
                              "Mamenchisaurus", 
                              "Deinonychus", 
                              "Edmontosaurus"};
    static int[] positions = new int[dinosaurs.Length];
    static void Main()
    {
        
        int[] strLen = new int[dinosaurs.Length];        

        for (int i = 0; i < dinosaurs.Length; i++)
        {
            strLen[i] = dinosaurs[i].Length;
            positions[i] = i;
        }

        Sort(strLen);

        for (int i = 0; i < positions.Length; i++)
        {
            Console.Write(dinosaurs[positions[i]] + " ");
        }
        Console.WriteLine();

    }

    static void Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                    temp = positions[j];
                    positions[j] = positions[j + 1];
                    positions[j + 1] = temp;
                }
            }
        }
    }
}

