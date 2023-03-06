using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace паук_и_муха
{
    internal class Program
    {
        public static double Arif(double x,double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        static void Main(string[] args)
        {
            double result=0;
           int ax = Convert.ToInt32(Console.ReadLine());
           int by = Convert.ToInt32(Console.ReadLine());
           int cz = Convert.ToInt32(Console.ReadLine());
            int sx = Convert.ToInt32(Console.ReadLine());
            int sy = Convert.ToInt32(Console.ReadLine());
            int sz = Convert.ToInt32(Console.ReadLine());
            int fx = Convert.ToInt32(Console.ReadLine());
            int fy = Convert.ToInt32(Console.ReadLine());
            int fz = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[4];
            // для противоположных сторон
            if (Math.Abs(fx - sx)==ax)
            {
                arr[0] = Arif(ax + 2 * by - (fy + sy), fz - sz);
                arr[1] =Arif(ax + 2 * by - (fy + sy), fz - sz);
                arr[2] = cz;
                arr[3] = Arif(ax + fz + sz, fy - sy);
                result = arr.Min();
            }
            if (Math.Abs(fy - sy) == by)
            {
                arr[0] = Arif(by + 2 * ax - (fx + sx), fz - sz);
                arr[1] = Arif(by + fx + sx, fz - sz);
                arr[2] = Arif(by + 2 * cz - (fz + sz), fx - sx);
                arr[3] = Arif(by + fz + sz, fx - sx);
                result = arr.Min();
            }
            if (Math.Abs(fz - sz) == cz)
            {
                arr[0] = Arif(cz + 2 * ax - (fx + sx), fy - sy);
                arr[1] = Arif(ax + 2 * by - (fy + sy), fz - sz);
                arr[2] = Arif(cz + fx + sx, fy - sy);
                arr[3] = Arif(cz + fy + sy, fx - sx);
                result = arr.Min();
            }

            // для смежных или одинаковых сторон
            if (sy == 0)
                result = Arif(sx - fx, fy + (cz - sz));
            if (sx == 0)
                result =Arif(sz + fx, sy - fy);
            if (sy == 0 && fz == sz)
                result = Arif(sx - fx, sy - fy);
            if (sy == 0 & fy == 0)
                result = Arif(fx - sx, sz - fz); 
            if (sx == ax)
                result = Arif(sz - fz, (by - sy) + (ax - fx));
            if (sx == ax&&fy==0)
                result = Arif(sz - fz, sy+ax-fx);
            if (sx == 0 && fy == 0)
                result = Arif(sz - fz, sy+fx);
            if (sx==0&&fz==0) //
               result= (Arif(sz, fy-sy)+fx);
            if (sx == 0 && by == fy)
                result = Arif(sz - fz, (by - sy) + fx);
            if(by==sy&&fz==0)
                result= Arif(sz +(sy-fy) ,sx-fx);
            if(fz==cz&&sx==ax)
                result = Math.Abs(ax-fx)+Math.Abs(cz-sz);
            if (sx==0&&sz==0&&sx==sz && fx == ax&&fz==cz)
                result = Arif(fz,fx);
            //c 17-19 когда точки на одном ребре
            if(sx==fx&&sy==fy)
                result = Math.Abs(sz-fz);
             
            if (sz == fz && sy == fy)
                result= Math.Abs(sx-fx);
            if (sz == fz && sx == fx)
                result = Math.Abs(sy - fy);

            if (fy == fz && sz == sy && fx == 0 && sx == 0)
                result = Math.Abs(fy * Math.Sqrt(2) - sy * Math.Sqrt(2));
            if (sx == 0)
                result = Arif(sz + fx, sy - fy);
            else
                result = 0;
            Console.WriteLine(Math.Round(result, 3));

            }

    }
}
