using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long takenPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percGoodPic = long.Parse(Console.ReadLine());
            long timeToUpload = long.Parse(Console.ReadLine());

            long filteredPic = (long) Math.Ceiling(takenPictures * (percGoodPic / 100.00));
            long allFilterTime = filterTime * takenPictures;
            long totalTimeToupload = filteredPic * timeToUpload;
            long totalTimeSec = (allFilterTime + totalTimeToupload);

            TimeSpan dateFormat = TimeSpan.FromSeconds(totalTimeSec);
            string allTime = dateFormat.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(allTime);

           // long totalTimeMin = 0;
           //long totalTimeH=0;
           // long totalTimeDays = 0;

            //while (totalTimeSec>59)
            //{
              //  totalTimeSec -= 60;
                //totalTimeMin++;
                //if(totalTimeMin>59)
                //{
                  //  totalTimeMin -= 60;
                 //totalTimeH++;
                //}
               // if(totalTimeH>23)
                //{
                  //  totalTimeH -= 24;
                   // totalTimeDays++;
               // }
            //}
            //Console.WriteLine($"{totalTimeDays}:{totalTimeH:D2}:{totalTimeMin:D2}:{totalTimeSec:D2}");
        }
    }
}
