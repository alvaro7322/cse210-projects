using System;
using System.Collections.Generic;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
 
        Video video1 = new Video("Learning C# Basics", "Code Academy", 620);
        video1.AddComment(new Comment("John", "This helped me a lot, thanks!"));
        video1.AddComment(new Comment("Maria", "Great explanation."));
        video1.AddComment(new Comment("David", "Can you make a part 2?"));
 
        Video video2 = new Video("Top 10 Travel Spots", "World Explorer", 845);
        video2.AddComment(new Comment("Sara", "Adding these to my bucket list!"));
        video2.AddComment(new Comment("Luis", "Number 5 is amazing."));
        video2.AddComment(new Comment("Anna", "Which camera do you use?"));
        video2.AddComment(new Comment("Tom", "Great video as always."));
 
        Video video3 = new Video("Easy Pasta Recipe", "Chef Mike", 300);
        video3.AddComment(new Comment("Karen", "Tried this last night, delicious!"));
        video3.AddComment(new Comment("Peter", "How long does it take to prepare?"));
        video3.AddComment(new Comment("Lucy", "Can I use a different sauce?"));
 
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
 
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
 
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("  " + comment.GetCommenterName() + ": " + comment.GetText());
            }
 
            Console.WriteLine();
        }
    }
}