using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort.HeapSort
{
    public class Count
    {
        public static int size;
    }

    class Sort
    {
        /// <summary>
        /// Функция обмена двух целых значений.
        /// </summary>
        /// <param name="a">Первое значение</param>
        /// <param name="b">Второе значение</param>
        public static void swap(ref long a, ref long b)
        {
            long temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Функция постройки бинарной кучи
        /// </summary>
        /// <param name="arr">Массив из которого будет построенна куча</param>
        /// <param name="n">Размер кучи</param>
        public static void bildHeap(ref long[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                siftDown(arr, n, i);
        }

        /// <summary>
        /// Пирамидальная сортировка
        /// </summary>
        /// <param name="arr">Сортируемый массив</param>
        public static void heapSort(ref long[] arr)
        {
            int n = arr.Length;
            bildHeap(ref arr, n);

            for (int i = n - 1; i >= 0; i--)
            {
                swap(ref arr[0], ref arr[i]);
                siftDown(arr, i, 0);
            }
        }

        /// <summary>
        /// Функция подрежания свойст пиармиды
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="n">Размер кучи</param>
        /// <param name="i">i-ый элемент</param>
        public static void siftDown(long[] arr, long n, int i)
        {
            int size = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[size])
                size = left;
            if (right < n && arr[right] > arr[size])
                size = right;

            if (size != i)
            {
                swap(ref arr[i], ref arr[size]);
                siftDown(arr, n, size);
            }
        }

        /// <summary>
        /// Возвращение отсортированного массива в строку
        /// </summary>
        /// <param name="arr">Массив</param> 
        public static string outputMainArray(ref long[] arr)
        {
            string line = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 10 == 0 && i != 0)
                    line += '\n';
                line += arr[i] + " ";
            }
            return line;
        }

        /// <summary>
        /// Возвращение отсортированного массива в файл
        /// </summary>
        /// <param name="arr">Массив</param> 
        public static string outputArray(ref long[] arr)
        {
            string line = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 8 == 0 && i != 0)
                    line += '\n';
                line += arr[i] + " ";
            }
            return line;
        }

        /// <summary>
        /// Считывание массива с поля
        /// </summary>
        /// <returns></returns>
        public static long[] arrayReadText(string input)
        {
            char[] revmove = { ' ', '\n' };
            string[] str = input.Split(revmove);
            long[] rez = new long[str.Length];
            try
            {
                for (int i = 0; i < str.Length; i++)
                    rez[i] = long.Parse(str[i]);
                Size(str.Length);
            }
            catch (Exception)
            {
                DialogResult result;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string message = "Входная строка имеет лишние символы или неверный формат ввода.\nВозможно одно из чисел последовательности привышает допустимые значения";
                string caption = "Ошибка ввода данных";
                result = MessageBox.Show(message, caption, buttons);
            }
            return rez;
        }

        public static void Size(int n)
        {
            HeapSort.Count.size = n;
        }
    }
}
