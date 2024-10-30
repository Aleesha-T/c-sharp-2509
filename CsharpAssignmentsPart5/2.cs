using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignmentsPart5
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
    }
    public class MovieLibrary
    {
        public Movie[] Movies = new Movie[5];
        public void AddMovie(Movie movie, int index)
        {
            Movies[index] = movie;
        }
        public void Display()
        {
            Console.WriteLine("Movies:");
            foreach (var movie in Movies)
            {
                Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
            }
        }
    }
}
