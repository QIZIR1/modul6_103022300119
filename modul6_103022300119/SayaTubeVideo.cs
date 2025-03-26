using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300119
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string tittle)
        {
            Debug.Assert(tittle != null, "Judul video tidak boleh null.");
            Debug.Assert(tittle.Length <= 200, "Judul video tidak boleh ");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video: {id}");
            Console.WriteLine($"Judul Video: {title}");
            Console.WriteLine($"Jumlah Play Count: {playCount}");
        }

        public int getPlayCount()
        {
            return playCount;
        }
    }
}
