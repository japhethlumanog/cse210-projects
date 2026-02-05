using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Building Strong Family Relationships", "Family First Channel", 780);

        video1.AddComment(new Comment("Maria", "This reminded me to spend more time with my parents."));
        video1.AddComment(new Comment("John", "Family really is everything."));
        video1.AddComment(new Comment("Anna", "Such a warm and meaningful video."));

        videos.Add(video1);

        Video video2 = new Video("Exploring Japan on a Budget",
            "WanderWithMe",
            1020);

        video2.AddComment(new Comment("Kevin", "Japan is now on my bucket list!"));
        video2.AddComment(new Comment("Liza", "The tips were very helpful."));
        video2.AddComment(new Comment("Mark", "Loved the food shots 😍"));

        videos.Add(video2);

        Video video3 = new Video("Why Manual Cars Are Still Fun to Drive",
            "Car Enthusiast PH",
            650);

        video3.AddComment(new Comment("Ryan", "Manual driving feels more connected."));
        video3.AddComment(new Comment("Paolo", "Great explanation for beginners."));
        video3.AddComment(new Comment("Sean", "I miss driving stick shift."));

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine();

            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
                
            }

            Console.WriteLine();
        }

    }
}