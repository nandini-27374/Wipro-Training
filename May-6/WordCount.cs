class program
{
    public static void Main()
    {
        string sentence = "Learning C# is fun";

        string[] words= sentence.Split(' ');

        int wordCount =words.Length;

        Console.WriteLine(wordCount);
    }
}
