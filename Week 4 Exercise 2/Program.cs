using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Exercise_2
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Initialize the array 

            while (true)
            {
                // Prompts the user with the options they can choose
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Print all elements of the array");
                Console.WriteLine("2. Calculate and print the sum of all elements");
                Console.WriteLine("3. Find and print the max and min values");
                Console.WriteLine("4. Reverse the array and print the reversed array");
                Console.WriteLine("5. Exit");

                // Prompts user to enter their choice
                Console.Write("Enter your choice (1-5): ");
                string input = Console.ReadLine(); // takes users input

                if (int.TryParse(input, out int choice)) // if user makes a valid choice, selects correct case
                {
                    switch (choice)
                    {
                        case 1: // prints the array
                            PrintArray(numbers);
                            break;

                        case 2: // sum of array
                            int sum = CalculateSum(numbers);
                            Console.WriteLine($"Sum of all elements: {sum}");
                            break;

                        case 3: // for max and min
                            int max = FindMax(numbers);
                            int min = FindMin(numbers);
                            Console.WriteLine($"Max value: {max}");
                            Console.WriteLine($"Min value: {min}");
                            break;

                        case 4: // reverse array
                            int[] reversedArray = ReverseArray(numbers);
                            Console.WriteLine("Reversed array:");
                            PrintArray(reversedArray);
                            break;

                        case 5: // exits the list
                            Console.WriteLine("Exiting...");
                            return; // Exit the application

                        default: // if user inputs wrong choice it prints this
                            Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5."); // if user makes invalid input it prints this
                }
            }
        }

        static void PrintArray(int[] array) // method for print array
        {
            Console.WriteLine("Array elements:"); // prompts user the array
            foreach (int item in array) // counts each item in array
            {
                Console.Write(item + " "); //  prints the elements
            }
            Console.WriteLine();
        }

        static int CalculateSum(int[] array) // method for sum
        {
            int sum = 0;
            foreach (int item in array) // counts each item in array
            {
                sum += item;
            }
            return sum; // returns the sum
        }

        static int FindMax(int[] array) // method for max
        {
            int max = array[0];
            foreach (int item in array) // counts each item in array
            {
                if (item > max) // compares item to the max
                {
                    max = item;
                }
            }
            return max; // returns the max number
        }

        static int FindMin(int[] array) // method for min
        {
            int min = array[0];
            foreach (int item in array) // counts each item in array
            {
                if (item < min) // compares item to the min value in array
                {
                    min = item;
                }
            }
            return min; // returns the min value
        }

        static int[] ReverseArray(int[] array) // method for reversearray
        {
            int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++) // goes through each item in array
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed; // returns the reverse array
        }
    }
}
