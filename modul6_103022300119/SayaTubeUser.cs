using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300119
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string nama)
        {
           this.Username = nama;
            uploadedVideos = new List<SayaTubeVideo>();
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
        }

        public int GetTotalVideoPlayCount()
        {
            int hasil = 0;

            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                hasil += uploadedVideos[i].getPlayCount();
            }

            return hasil;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlay()
        {
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                video.PrintVideoDetails();
            }
        }
    }
}
