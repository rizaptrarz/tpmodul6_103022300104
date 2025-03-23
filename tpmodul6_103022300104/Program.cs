using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo videos = new SayaTubeVideo("Tutorial Design By Contract - Riza Muhammad Putra");

        for (int i = 0; i < 3; i++)
        {
            videos.IncreasePlayCount(10000000);
            videos.PrintVideoDetails();
        }

        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Riza Muhammad Putra");
            video.IncreasePlayCount(10000001);
            video.PrintVideoDetails();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
