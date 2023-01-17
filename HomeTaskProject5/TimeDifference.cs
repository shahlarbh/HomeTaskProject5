using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskProject5
{
    internal class TimeDifference
    {
        internal string Difference(string time1, string time2, out string time3)
        {
            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

            int h3 = h2 - h1;
            int m3 = m2 - m1;
            int s3 = s2 - s1;

            if (h2 < h1)
            {
                h3 = (h2 + 24) - h1;
            }

            if (m2 < m1)
            {
                m3 = (m2 + 60) - m1;
                h2 = h2 - 1;
            }

            if (s2 < s1)
            {
                s3 = (s2 + 60) - s1;
                m2 = m2 - 1;
            }

            string x = h3.ToString().PadLeft(2, '0');
            string y = m3.ToString().PadLeft(2, '0');
            string z = s3.ToString().PadLeft(2, '0');

            time3 = $"{x}:{y}:{z}";

            return time3;
        }

        internal string StartTime()
        {
            Console.Write("Imtahanin baslama vaxtini qeyd edin:");
            string time1 = Console.ReadLine();

            return time1;
        }

        internal string FinishTime()
        {
            Console.Write("Imtahanin bitme vaxtini qeyd edin:");
            string time2 = Console.ReadLine();

            return time2;
        }
    }
}
