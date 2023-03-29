using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210022
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public int getPlayCount()
        {
            return playCount;
        }

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
            
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Playcount: " + playCount);
        }

    }
}
