using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        int videoNum = 4;
        Random random = new Random();
        List<string> comments = new List<string>()
        {
            "This video is bad.", "This video is good.", "I liked the part where you showed your true self.",
            "I wish you were more real in this video.", "first", "The algorithm strikes again", "Hey, you just earned yourself a new subscriber!",
            "This video isn't it", "I liked your older stuff better", "I've never thought about it like that", "Best part of the video 0:00 ",
            "Click this to repeat the video 0:00", "Click my profile picture for free subscribers!", "Little did he know...", "I forgot about your channel",
            "Wow, I'll try that next time!"
        };
        List<string> commenters = new List<string>()
        {
            "danger_man","funnyguy4256","baconator2","tseranac","joe edgar","mrcoolguy","Ihavethebestname","mario_mario5367",
            "luigi_mario261","gokubeatssuperman","Rachael Zackery","noname2225","serpramelymissspeled","missrandom","superdude7454",
            "thesanitizer"
        };
        List<string> authors = new List<string>()
        {
            "Because It's Funny", "The Trumpet Guys", "PompeiitheXVII","CantstopWontstop" 
        };
        List<string> videoTitles = new List<string>()
        {
            "I can't believe this is happenning...", "You won't believe this happened!", "The history of...", "Reading your comments."
        };
        for (int i = 0; i < videoNum; i++)
        {
            List<Comment> videoComments = new List<Comment>();
            for (int n = 0; n < 4; n++)
            {
                int commentNum = random.Next(comments.Count);
                int commenterNum = random.Next(commenters.Count);
                Comment comment = new Comment(commenters[commenterNum],comments[commentNum]);
                videoComments.Add(comment);
                commenters.Remove(commenters[commenterNum]);
                comments.Remove(comments[commentNum]);
            }
            int authorNum = random.Next(authors.Count);
            int videoTitlesNum = random.Next(videoTitles.Count);
            int length = random.Next(300,901);
            Video video = new Video(authors[authorNum],videoTitles[videoTitlesNum],length,videoComments[0],videoComments[1],videoComments[2],videoComments[3]);
            authors.Remove(authors[authorNum]);
            videoTitles.Remove(videoTitles[videoTitlesNum]);
            videos.Add(video);
        }
        foreach (Video video in videos)
        {
            video.GetVideoInformation();
        }
    }
}