using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{

class Program
        {
            static void Main()
            {
                Console.Write("Enter the size of the arrays: ");
                int size = int.Parse(Console.ReadLine());

                // Get user input for the first array
                double[] array1 = GetArrayFromUser(size);

                // Get user input for the second array
                double[] array2 = GetArrayFromUser(size);

                // Scalar Sum
                double scalarSumResult = ScalarSum(array1);
                Console.WriteLine("Scalar Sum: " + scalarSumResult);

                // Vector Sum
                double[] vectorSumResult = VectorSum(array1, array2);
                Console.WriteLine("Vector Sum: " + string.Join(", ", vectorSumResult));

                // Vector Product
                double[] vectorProductResult = VectorProduct(array1, array2);
                Console.WriteLine("Vector Product: " + string.Join(", ", vectorProductResult));

                // Scalar Product
                double scalarProductResult = ScalarProduct(array1);
                Console.WriteLine("Scalar Product: " + scalarProductResult);

                // Scalar Product Sum
                double scalarProductSumResult = ScalarProductSum(vectorProductResult);
                Console.WriteLine("Scalar Product Sum: " + scalarProductSumResult);
            }

            static double[] GetArrayFromUser(int size)
            {
                double[] array = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + (i + 1) + ": ");
                    array[i] = double.Parse(Console.ReadLine());
                }
                return array;
            }

            static double ScalarSum(double[] array)
            {
                double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }

            static double[] VectorSum(double[] array1, double[] array2)
            {
                if (array1.Length != array2.Length)
                {
                    throw new ArgumentException("Arrays must be of the same length for vector sum.");
                }

                double[] result = new double[array1.Length];
                for (int i = 0; i < array1.Length; i++)
                {
                    result[i] = array1[i] + array2[i];
                }
                return result;
            }

            static double[] VectorProduct(double[] array1, double[] array2)
            {
                if (array1.Length != array2.Length)
                {
                    throw new ArgumentException("Arrays must be of the same length for vector product.");
                }

                double[] result = new double[array1.Length];
                for (int i = 0; i < array1.Length; i++)
                {
                    result[i] = array1[i] * array2[i];
                }
                return result;
            }

            static double ScalarProduct(double[] array)
            {
                double product = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    product *= array[i];
                }
                return product;
            }

            static double ScalarProductSum(double[] array)
            {
                double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
        }

    }


