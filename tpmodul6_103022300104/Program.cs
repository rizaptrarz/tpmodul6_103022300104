using tpmodul6_103022300104;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Riza Muhammad Putra");
        video.PrintVideoDetails();

        video.IncreasePlayCount(3000); 
        video.IncreasePlayCount(7000); 
        video.PrintVideoDetails();
    }
}
