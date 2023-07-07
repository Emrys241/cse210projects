using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
    
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video()
        {
            Title = "Video 1",
            Author = "Author 1",
            Length = 300,
            Comments = new List<Comment>()
            {
                new Comment() { CommenterName = "User 1", Text = "Comment 1" },
                new Comment() { CommenterName = "User 2", Text = "Comment 2" },
                new Comment() { CommenterName = "User 3", Text = "Comment 3" },
                new Comment() { CommenterName = "User 4", Text = "Comment 4" }
            }
        };
        videos.Add(video1);

        Video video2 = new Video()
        {
            Title = "Video 2",
            Author = "Author 2",
            Length = 450,
            Comments = new List<Comment>()
            {
                new Comment() { CommenterName = "User 4", Text = "Comment 4" },
                new Comment() { CommenterName = "User 5", Text = "Comment 5" }
            }
        };
        videos.Add(video2);

        Video video3 = new Video()
        {
            Title = "Video 3",
            Author = "Author 3",
            Length = 600,
            Comments = new List<Comment>()
            {
                new Comment() { CommenterName = "User 6", Text = "Comment 6" },
                new Comment() { CommenterName = "User 7", Text = "Comment 7" },
                new Comment() { CommenterName = "User 8", Text = "Comment 8" }
            }
        };
        videos.Add(video3);

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine("Commenter: " + comment.CommenterName);
                Console.WriteLine("Text: " + comment.Text);
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------");
        }

        Console.ReadLine();
    }
}
