using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video vid1 = new Video("Cat Video", "Joe Thomas", 20);
        vid1.AddComment("Melanie Gines", "Funniest video ever!");
        vid1.AddComment("Joseph Monroe", "That cat should be given a grammy.");
        vid1.AddComment("Carla Gordon", "This other video is funnier.");
        vid1.AddComment("Sam Ryan", "Perfect!");


        Video vid2 = new Video("C# Demo", "Dr. Bob Lee", 80);
        vid2.AddComment("Linda Cox", "Super helpful!");
        vid2.AddComment("Michael Foley", "Helped a ton, thanks!");
        vid2.AddComment("Rebekah Thompson", "I was lost, thanks for explaining!");

        Video vid3 = new Video("Grow Your Garden", "Cynthia Platt", 60);
        vid3.AddComment("Sarah Cane", "Beautiful!");
        vid3.AddComment("Nathan Foss", "Excellent, I love this!");
        vid3.AddComment("Abby Foo", "The garden is enviable!");
        vid3.AddComment("Gideon Shine", "Way to go!");

        Video vid4 = new Video("Braiding Hair", "Stephanie Smith", 38);
        vid4.AddComment("Mary Shaw", "Come braid my hair!");
        vid4.AddComment("Rachel Greggory", "Oh, this looks like I could do it!");
        vid4.AddComment("Kaitlin Doe", "Such a great demonstration!");


        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);
        videos.Add(vid4);

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine();
            video.ReturnComments();
            Console.WriteLine("Comments: ");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine();
                Console.WriteLine($"{comment._name}");
                Console.WriteLine($"{comment._text}");
                Console.WriteLine();
            }
        }


        
    }
}