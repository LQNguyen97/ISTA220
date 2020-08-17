using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise05_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //ARRAY A CODES:
            int countA = A.Length;
            int SumA = A.Sum();
            double AvgA = SumA / countA;
            Console.WriteLine($"The count of array A is {countA}. " +
                              $"\nThe Sum of array A is {SumA}. " +
                              $"\nThe average of array A is {AvgA}");
            ReverseArray(A);
            Rotate(A, 2, true);

            Console.WriteLine("\n");


            //ARRAY B CODES:
            int countB = B.Length;
            int SumB = B.Sum();
            double AvgB = SumB / countB;
            Console.WriteLine($"The count of array B is {countB}. " +
                              $"\nThe Sum of array B is {SumB}. " +
                              $"\nThe average of array B is {AvgB}");
            ReverseArray(B);
            Rotate(B, 2, false);

            Console.WriteLine("\n");


            //ARRAY C CODES:
            int countC = C.Length;
            int SumC = C.Sum();
            double AvgC = SumC / countC;
            Console.WriteLine($"The count of array C is {countC}. " +
                              $"\nThe Sum of array C is {SumC}. " +
                              $"\nThe average of array C is {AvgC}");
            ReverseArray(C);
            Rotate(C, 4, true);
            Sort(C);

            int[] Sort(int[] arr)
            {
                int temp = 0;
                int count = 0;
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            count++;
                        }
                        if (count == arr.Length)
                        {
                            Console.WriteLine("Sorted Array: [{0}]", string.Join(", ", arr));
                        }
                    }
                }
                return arr;
            }

                int[] ReverseArray(int[] arr)
            {
                var newArray = new int[arr.Length];
                int count = 0;



                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    newArray[count] = arr[i];
                    count++;



                    if (count == arr.Length)
                    {
                        Console.WriteLine("Reversed Array: [{0}]", string.Join(", ", newArray));
                    }
                }
                return newArray;
            }

            int[] Rotate(int[] arr, int k, bool isRight)
            {
                int j = 0;

                if (k > arr.Length)
                    throw new IndexOutOfRangeException();

                while (k > 0)
                {

                    if (isRight)
                    {
                        int temp = arr[arr.Length - 1];
                        for (j = arr.Length - 1; j > 0; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[j] = temp;
                        k--;
                    }
                    else
                    {

                        if (k > arr.Length)
                            throw new IndexOutOfRangeException();
                        int temp = arr[0];
                        for (j = 0; j < arr.Length - 1; j++)
                        {
                            arr[j] = arr[j + 1];
                        }
                        arr[j] = temp;
                        k--;
                    }
                }
                Console.WriteLine("Rotated Array: [{0}]", string.Join(", ", arr));
                return arr;
            }

        }
    }
}
    
