using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Soccer", "Daniel Zavala", "5:00");
        video1.AddComment(new Comment("Joe", "Great video"));
        video1.AddComment(new Comment("Annie", "Bad audio"));
        video1.AddComment(new Comment("Mark", "I love soccer too!"));

        videos.Add(video1);

        Video video2 = new Video("Monkeys", "John Doe", "15:00");
        video2.AddComment(new Comment("Jake", "Monkeys are awesome!"));
        video2.AddComment(new Comment("Billy", "I don't believe that monkeys exist"));
        video2.AddComment(new Comment("Harvey", "Very educational"));

        videos.Add(video2);

        Video video3 = new Video("Taco Bell", "Food Reviewer", "10:00");
        video3.AddComment(new Comment("Juan", "It's not authentic!"));
        video3.AddComment(new Comment("Mason", "I love Taco Bell"));
        video3.AddComment(new Comment("James", "Best mexican food ever!"));

        videos.Add(video3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"\nTitle: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()}");
            Console.WriteLine($"Comments: {v.GetCommentCount()}");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"- {c.GetAuthor()}: {c.GetText()}");
            }
        }
    }
}