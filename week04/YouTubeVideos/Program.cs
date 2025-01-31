using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create videos
        var video1 = new Video("Learning C#", "John Doe", 600);
        var video2 = new Video("Cooking Pasta", "Jane Smith", 900);
        var video3 = new Video("Travel Vlog", "Alice Johnson", 1200);

        // Add comments to videos
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "I learned a lot."));

        video2.AddComment(new Comment("User4", "Yummy recipe!"));
        video2.AddComment(new Comment("User5", "Can't wait to try this."));
        video2.AddComment(new Comment("User6", "Looks delicious!"));

        video3.AddComment(new Comment("User7", "Amazing vlog!"));
        video3.AddComment(new Comment("User8", "Beautiful places."));
        video3.AddComment(new Comment("User9", "I want to visit there!"));

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
