using System;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videos = new List<Video>();

        // Video number 1
        Video video1 = new Video("How to Code in C#", "Vincent T.", 300);
        video1.AddComment(new Comment("Alice", "This was very helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing!"));
        videos.Add(video1);

        // Video number 2
        Video video2 = new Video("BYU-Idaho Devotional", "BYU-I", 1800);
        video2.AddComment(new Comment("David", "So uplifting."));
        video2.AddComment(new Comment("Emma", "Wonderful message."));
        video2.AddComment(new Comment("Liam", "I love these talks."));
        videos.Add(video2);

        // Video number 3
        Video video3 = new Video("Fiji Nature Documentary", "IslandLife", 1200);
        video3.AddComment(new Comment("Noa", "Proud to be Fijian."));
        video3.AddComment(new Comment("Sarah", "So beautiful!"));
        video3.AddComment(new Comment("Tom", "Breathtaking views."));
        videos.Add(video3);

        // this is where we will display the videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Blank lines between the videos
        }
    }
}