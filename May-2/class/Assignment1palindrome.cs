using System;
class Program
{
   static void Main()
       {
          string word="malayalam" ;
          string rev="";
          for (int i=word.Length-1;i>=0;i--)
          {
              rev=rev+word[i];
          }
          if (word == rev)
          {
              Console.WriteLine($"{word} is a paindrome");
          }
          else
          {
              Console.WriteLine($"{word} is not a paindrome");
          }
       }
}