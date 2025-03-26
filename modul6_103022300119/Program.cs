using modul6_103022300119;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Riziq Rizwan");

        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial C# - part 1");
        SayaTubeVideo video2 = new SayaTubeVideo("Tutorial C# - part 2");
        SayaTubeVideo video3 = new SayaTubeVideo("Tutorial C# - part 3");

        video1.IncreasePlayCount(5000);
        video2.IncreasePlayCount(10000);
        video3.IncreasePlayCount(20000);

        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);

        Console.WriteLine("\n========== Daftar Video ==========");
        user.PrintAllVideoPlay();

        Console.WriteLine($"\nTotal Play Count Dari Semua VIdeo: {user.GetTotalVideoPlayCount()}");
    }
}