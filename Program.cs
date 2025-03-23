using tpmodul6_103022300049;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Shinta Alya Aulya N");

        for (int i = 0; i < 5; i++)
        {
            video.IncreasePlayCount(2500000);
        }

        video.PrintVideoDetails();
    }
}

