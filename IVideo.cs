using System;

interface IVideo
{
    public string name { get; set; }
    public int rating { get; set; }
    public string director { get; set; }
}
public class Movie : IVideo
{
    public string name { get; set; }
    public int rating { get; set; }
    public string director { get; set; }
    public Movie(string name, int rating, string director)
    {
        this.name = name;
        this.rating = rating;
        this.director = director;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"name {name} rating {rating} director {director} ");
    }
}

public class Series : IVideo
{
    public string name { get; set; }
    public int rating { get; set; }
    public string director { get; set; }
    public Series(string name, int rating, string director)
    {
        this.name = name;
        this.rating = rating;
        this.director = director;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"name {name} rating {rating} director {director} ");
    }
    }

public class Program
{
    static void AddMovie()
    {
        Console.WriteLine("Enter movie name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the rating: ");
        int rating = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the director name: ");
        string director = Console.ReadLine();

        Movie movie = new Movie(name, rating, director);
        videos.Add(movie);
        Console.WriteLine("Movie added!");
    }
    static void AddSeries()
    {
        Console.WriteLine("Enter series name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the rating: ");
        int rating = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the director name: ");
        string director = Console.ReadLine();

        Series series = new Series(name, rating, director);
        videos.Add(series);
        Console.WriteLine("Movie added!");
    }
    static void Display()
    {
        foreach (var video in videos)
        {
            if (video is Movie)
            {
                ((Movie)video).DisplayInfo();
            }
            else if (video is Series)
            {
                ((Series)video).DisplayInfo();
            }
        }
    }
    static List<IVideo> videos = new List<IVideo>();
    public static void Main(string[] args)
    {
        
        AddMovie();
        AddSeries();
        Display();
    }
    
}
