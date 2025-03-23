using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300049
{
    public class SayaTubeVideo
    {
        private int id;
        private string judul;
        private int jumlahPutar;

        public SayaTubeVideo(string judul)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.judul = judul;
            this.jumlahPutar = 0;
        }

        public void TambahJumlahPutar(int jumlah)
        {
            jumlahPutar += jumlah;
        }

        public void CetakDetailVideo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Judul: {judul}");
            Console.WriteLine($"Jumlah Putar: {jumlahPutar}");
        }
    }

}



