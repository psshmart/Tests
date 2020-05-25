using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace testruby
{
    public class Row
    {
        /// <summary>
        /// Лист элементов, поступающий в метод NewString
        /// </summary>
        public List<int> numbers = new List<int>();

        /// <summary>
        /// Лист, в который закладывается получающаяся последовательность
        /// </summary>
        public List<string> lines = new List<string>();

        /// <summary>
        /// Счетчик 
        /// </summary>
        public int i;


        /// <summary>
        /// Создание последовательности
        /// </summary>
        /// <param name="element">первый элемент</param>
        /// <param name="linesnumber">кол-во строчек</param>
        public Row(int element, int linesnumber)
        {
            lines.Add(element.ToString());
            Console.WriteLine(lines[0]);
            i = 0;

            while (i <= linesnumber)
            {
                foreach (char elem in lines[i])
                {
                    int el = int.Parse(elem.ToString());
                    numbers.Add(el);
                }
                var add = NewString(numbers);
                lines.Add(add);
                Console.WriteLine(lines[i + 1]);
                i++;
                numbers.Clear();
            }
            

        }

        /// <summary>
        /// Генерация следующей строки
        /// </summary>
        /// <param name="first">Лист значений предыдущей строки</param>
        /// <returns>Возвращается готовая новая строка</returns>
        public static string NewString(List<int> first)
        {
            StringBuilder line = new StringBuilder();

            int count = 1;

            if (first.Count == 1)
            {
                line.Append(1);
                line.Append(first[0]);
                return line.ToString();
            }

            for (int i = 0; i < first.Count - 1; i++)
            {
                if ((first[i] != first[i + 1] && first.Count != 1) || i == first.Count - 1)
                {
                    line.Append(count);
                    line.Append(first[i]);
                    count = 0;
                }
                count++;
            }

            line.Append(count);
            line.Append(first[first.Count - 1]);
            return line.ToString();
        }
    }
}
