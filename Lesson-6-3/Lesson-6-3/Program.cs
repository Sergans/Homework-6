using System;

namespace Lesson_6_3
{
    class Program
    {
        [Serializable]
        public class MyArraySizeException : Exception { };
        public class MyArrayDataException : Exception
        {
            public MyArrayDataException(string message) : base(message)
            {

            }
        }
        static void Main(string[] args)
        {
            // Массив 4*4 с строкой адрес ошибки[1,3]
            string[,] arr = { { "1", "2", "3", "4" }, { "1", "2", "3", "cv" }, { "1", "2", "3", "4" }, { "1", "2", "3", "4" } };
            // Массив другого размера
            //string[,] arr = { { "1", "2", "3", "4" }, { "1", "2", "3", "4" } };
            Console.WriteLine(ArrSum(arr));
        }
        static int ArrSum(string[,] a)
        {
            int sum = 0;
            try
            {
                if (a.GetLength(0) != 4 || a.GetLength(1) != 4)
                {
                    throw new MyArraySizeException();
                }

                int[,] arrInt = new int[4, 4];

                for (int j = 0; j < 4; j++)
                {

                    for (int i = 0; i < 4; i++)
                    {

                        if (int.TryParse(a[j, i], out int nom) == false)
                        {

                            throw new MyArrayDataException($"{j.ToString()} и {i.ToString()}");
                        }
                        arrInt[j, i] = Convert.ToInt32(a[j, i]);

                        sum = sum + arrInt[j, i];
                    }

                }

            }

            catch (MyArraySizeException)
            {
                Console.WriteLine("Ошибка: Массив должен быть 4*4");
            }
            catch (MyArrayDataException e)
            {
                Console.WriteLine($"В массиве не число");
                Console.WriteLine($"Ощибка по адресу массива: {e.ToString()}");
            }


            return sum;

        }
    }
}
