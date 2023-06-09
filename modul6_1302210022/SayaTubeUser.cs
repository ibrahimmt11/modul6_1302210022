﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210022
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string Username)
        {
            Random random = new Random();
            this.id = random.Next(10000,99999);
            this.Username = Username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);
            for(int i = 0; i <uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + i + 1 + "Judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
