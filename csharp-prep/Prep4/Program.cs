using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> theBigList = new List<int>();

        Console.WriteLine("This is you big list of numbers! you can add as many numbers that you want, but once you enter '0' it will give you info about your list!");


        //this is our loop

        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                keepGoing = false;
            }
            else
            {
                theBigList.Add(number);
            }
        }

        //this is the sum of the numbers
        int sum = 0;
        foreach (int number in theBigList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        //this is the average
        float average = ((float)sum) / theBigList.Count;
        Console.WriteLine($"The average is: {average}");


        //this is the largest number
        int bigNumber = theBigList[0];

        foreach (int number in theBigList)
        {
            if (number > bigNumber)
            {
                bigNumber = number;
            }
        }

        Console.WriteLine($"The largest number was: {bigNumber}");

    }
}