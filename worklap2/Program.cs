using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worklap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = new int[5]; // กำหนดอาร์เรย์ขนาด 5

            // รับ input 5 ค่า
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"กรุณาป้อนตัวเลขที่ {i + 1}: ");
                string inputA = Console.ReadLine();

                // แปลง string เป็น int
                int a = int.Parse(inputA);

                // add to array
                inputNumber[i] = a;
            }

            // เรียกใช้ฟังก์ชัน 
            CalculateStatistics(inputNumber, 5);
        }

        static void CalculateStatistics(int[] numbers, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("ไม่มีข้อมูลตัวเลข");
                return;
            }

            // ค่าเฉลี่ย
            double sum = 0;
            for (int j = 0; j < count; j++)
            {
                sum += numbers[j];
            }
            double mean = sum / count;

            // ค่าสูงสุด
            int maxVal = numbers[0];
            for (int j = 1; j < count; j++)
            {
                if (numbers[j] > maxVal)
                {
                    maxVal = numbers[j];
                }
            }

            // ค่าต่ำสุด
            int minVal = numbers[0];
            for (int j = 1; j < count; j++)
            {
                if (numbers[j] < minVal)
                {
                    minVal = numbers[j];
                }
            }

            // ค่ากลางข้อมูล (median)
            int[] sortedNums = new int[count];
            Array.Copy(numbers, sortedNums, count);
            Array.Sort(sortedNums);
            double median;
            if (count % 2 == 0)
            {
                median = (sortedNums[count / 2 - 1] + sortedNums[count / 2]) / 2.0;
            }
            else
            {
                median = sortedNums[count / 2];
            }

            // เรียงลำดับจากมากไปน้อย
            int[] descending = new int[count];
            Array.Copy(sortedNums, descending, count);
            Array.Reverse(descending);

            // เรียงลำดับจากน้อยไปมาก
            int[] ascending = new int[count];
            Array.Copy(sortedNums, ascending, count);

            // แสดงผล
            Console.WriteLine("ค่าเฉลี่ย: " + mean);
            Console.WriteLine("ค่าสูงสุด: " + maxVal);
            Console.WriteLine("ค่าต่ำสุด: " + minVal);
            Console.WriteLine("ค่ากลางข้อมูล: " + median);
            Console.Write("ข้อมูลเรียงลำดับจากมากไปน้อย: ");
            for (int j = 0; j < count; j++)
            {
                Console.Write(descending[j]);
                if (j < count - 1) Console.Write(", ");
            }
            Console.WriteLine();
            Console.Write("ข้อมูลเรียงลำดับจากน้อยไปมาก: ");
            for (int j = 0; j < count; j++)
            {
                Console.Write(ascending[j]);
                if (j < count - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
