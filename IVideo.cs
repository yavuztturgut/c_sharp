using System;
using System.Data;
using System.Linq.Expressions;

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
        try
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
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
    static void AddSeries()
    {
        try
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
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
    static void Display()
    {
        try
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
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
    static void Delete()
    {
        try
        {
            Console.WriteLine("Enter the name of the video you want to delete: ");
            string deleter = Console.ReadLine();
            IVideo videotodelete = null;
            foreach (var video in videos)
            {
                if (video.name.ToLower() == deleter.ToLower())
                {
                    videotodelete = video;
                    videos.Remove(videotodelete);
                    break;
                }

            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
    static List<IVideo> videos = new List<IVideo>();
    public static void Main(string[] args)
    {

        while (true)
        {
            try
            {
                Console.WriteLine("1 FOR ADDING\n2 FOR DISPLAYING\n3 FOR DELETING ");
                int menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("1 FOR MOVIES\n2 FOR SERIES");
                    menu = int.Parse(Console.ReadLine());
                    if (menu == 1)
                    {
                        AddMovie();
                    }
                    else if (menu == 2)
                    {
                        AddSeries();
                    }
                }
                else if (menu == 2)
                {
                    Display();
                }
                else if (menu == 3)
                {
                    Delete();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }

        }

    }
}
