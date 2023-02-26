using System;

namespace HomeWork2
{
    public class Program
    {
        /// <summary>
        /// Печатает массив на экран
        /// </summary>
        /// <param name="arr">Исходный массив</param>
        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }
        /// <summary>
        /// Печатает матрицу на экран
        /// </summary>
        /// <param name="matr">Исходная матрица</param>
        public static void PrintMatr(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                    Console.Write($"{matr[i, j]} ");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Возвращает новый массив, в котором удалены все элементы, не удовлетворяющие предикату
        /// </summary>
        /// <param name="arr">Исходный массив</param>
        /// <param name="f">Булевый предикат</param>
        /// <returns>Массив с такимже или меньшим количество элементов</returns>
        public static int[] Where(int[] arr, Func<int, bool> f)
        {
            int[] result = new int[arr.Length];
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
                if (f(arr[i]))
                    result[c++] = arr[i];
            Array.Resize(ref result, c);
            return result;
        }
        /// <summary>
        /// Возвращает нечётное число или нет
        /// </summary>
        /// <param name="num">Исходное число</param>
        /// <returns>Число нечётное?</returns>
        public static bool Odd(int num) => num % 2 != 0;
        /// <summary>
        /// Возвращает чётное число или нет
        /// </summary>
        /// <param name="num">Исходное число</param>
        /// <returns>Число чётное?</returns>
        public static bool Even(int num) => num % 2 == 0;
        /// <summary>
        /// Возвращает массив, в котором первая и вторая половина поменяны местами
        /// </summary>
        /// <param name="arr">Исходный массив</param>
        /// <returns>Массив с такимже или меньшим на 1 количество элементов</returns>
        public static int[] FlipHalves(int[] arr) => arr[(arr.Length / 2)..arr.Length].Concat(arr[0..(arr.Length / 2)]).ToArray();
        static void Main(string[] args)
        {
        }
    }
}