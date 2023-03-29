// See https://aka.ms/new-console-template for more information
using modul6_1302210022;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Ibrahim Mulyo Tsabit");
        SayaTubeVideo vd = new SayaTubeVideo("Rivew Iron Man oleh Ibrahim");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Review The Incredible Hulk oleh Ibrahim");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Iron Man 2");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Thor");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Captain America: The First Avenger");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("The Avengers");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Iron Man 3");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Thor: The Dark World");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Captain America: The Winter Soldier");
        user.AddVideo(vd);
        vd = new SayaTubeVideo("Guardians of the Galaxy");
        user.AddVideo(vd);

        user.PrintAllVideoPlaycount();
        vd.PrintVideoDetail();

    }
}
