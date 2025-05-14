using System;
interface IMusicPlayer
{
    void Play(string song);
    void Pause();
    void Stop();
}
class SpotifyPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing {song} on Spotify");
    }
    public void Pause()
    {
        Console.WriteLine("Spotify playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Spotify playback stoppes");
    }
}


class AppleMusicPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing {song} on Apple Music");
    }
    public void Pause()
    {
        Console.WriteLine("Apple Music playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Apple Music playback stopped");
    }
}

class Program3
{
    static void Main()
    {
        IMusicPlayer spotify = new SpotifyPlayer();
        IMusicPlayer applemp = new AppleMusicPlayer();

        spotify.Play("Yamuna Thatilo Nallanayyakai yedhuru chusene radha");
        spotify.Pause();
        spotify.Stop();

        applemp.Play("Sundhari nene nuvvanta");
        applemp.Pause();
        applemp.Stop();
    }
}