using System;

    namespace BoltSpike
    {
      internal class Program
      {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter a line of text:");
          string input = Console.ReadLine();

          if (IsLeftHandTypable(input))
          {
            Console.WriteLine("The text can be typed with the left hand only.");
          }
          else
          {
            Console.WriteLine("The text cannot be typed with the left hand only.");
          }
        }

        static bool IsLeftHandTypable(string text)
        {
          string leftHandKeys = "qwertasdfgzxcvbQWERTASDFGZXCVB";
          foreach (char c in text)
          {
            if (!leftHandKeys.Contains(c))
            {
              return false;
            }
          }
          return true;
        }
      }
    }
