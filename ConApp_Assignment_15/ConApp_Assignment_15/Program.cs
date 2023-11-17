using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Assignment_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the size of the array from the user
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            // Get the array elements from the user
            int[] array = GetArrayFromUser(size);

            Console.WriteLine("\nOriginal Array:");
            PrintArray(array);

            // Apply Bubble Sort in descending order
            BubbleSortDescending(array);

            Console.WriteLine("\nSorted Array using Bubble Sort:");
            PrintArray(array);

            // Check if the array is sorted correctly
            if (IsSorted(array))
            {
                Console.WriteLine("\nThe array is sorted correctly.");
            }
            else
            {
                Console.WriteLine("\nThe array is not sorted correctly.");
            }

            // Perform Binary Search
            Console.Write("\nEnter the number to search: ");
            int target = int.Parse(Console.ReadLine());
            int index = BinarySearch(array, target);

            if (index != -1)
            {
                Console.WriteLine($"{target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"{target} not found in the array.");
            }
        }

            // Bubble Sort in descending order
            static void BubbleSortDescending(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            // Swap elements
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }

            // Get array elements from the user
            static int[] GetArrayFromUser(int size)
            {
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                return array;
            }

            // Print the elements of an array
            static void PrintArray(int[] arr)
            {
                foreach (var element in arr)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            // Check if the array is sorted in descending order
            static bool IsSorted(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }

            // Binary Search
            static int BinarySearch(int[] arr, int target)
            {
                int low = 0;
                int high = arr.Length - 1;

                while (low <= high)
                {
                    int mid = (low + high) / 2;

                    if (arr[mid] == target)
                    {
                        return mid; // Element found
                    }
                    else if (arr[mid] < target)
                    {
                        high = mid - 1; // Search in the left half
                    }
                    else
                    {
                        low = mid + 1; // Search in the right half
                    }
                }

                return -1; // Element not found
            }
        }
    }

