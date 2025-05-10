using System;

class SocialMedia
{
    public virtual void Post()
    {
        Console.WriteLine("Posting on social media.");
    }
}

class FacebookPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Facebook.");
    }
}

class TwitterPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter.");
    }
}

class InstagramPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram.");
    }
}

class Program
{
    static void Main()
    {
        SocialMedia fb = new SocialMedia();
        fb.Post();//calls base method

        FacebookPost facebook = new FacebookPost();
        facebook.Post();//calls overriden method

        //Polymorphism
        TwitterPost twit = new TwitterPost();
        twit.Post();//Calls overridden method

        InstagramPost insta = new InstagramPost();
        insta.Post();//Calls overridden method
    }
}