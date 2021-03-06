﻿using System;

namespace pcarillo_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 25; // declare size of array variable
            int number = 1; // declare number variable
            int [] array = new int[size]; // declare array

            // for loop to iterate through each item inside array
            for (int i = 0; i <= size - 1; i += 1) // because first i equals 0, we need to subtract 1 from size to loop through 25 items
            {
                array [i] = number; // store number inside array
                Console.WriteLine("Element value: " + array[i]); // print a string followed by array item
                number += 1; // add 1 to variable number
            }
        }
    }
}