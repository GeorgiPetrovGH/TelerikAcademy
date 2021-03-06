﻿/*
Problem 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name, Last name, Age (0...100), Gender (m or f), Personal ID number (e.g. 8306112507), Unique employee number (27560000…27569999).
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.
*/

using System;

struct EmployeeInfo
{
   private string firstName;
   private string lastName;
   private byte age;
   private string gender;
   private long personalNumber;
   private long uniqueNumber;

    public void getValues(string f, string l, byte a, string g, long p, long u)
    {
        firstName = f;
        lastName = l;
        age = a;
        gender = g;
        personalNumber = p;
        uniqueNumber = u;
    }

    public void displayValues()
    {
        Console.WriteLine("First Name    : " + firstName);
        Console.WriteLine("Last Name     : " + lastName);
        Console.WriteLine("Age           : " + age);
        Console.WriteLine("Gender        : " + gender);
        Console.WriteLine("Id number     : " + personalNumber);
        Console.WriteLine("Unique number : " + uniqueNumber);
    }
};

class Employee
{
    static void Main()
    {
        EmployeeInfo employee01 = new EmployeeInfo();
        employee01.getValues("Ivan", "Ivanov", 106, "M", 8306112507, 27560000);
        employee01.displayValues();        
    }
}
