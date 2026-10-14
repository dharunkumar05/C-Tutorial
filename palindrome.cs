using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;

        input = input.ToLower();

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        string word = "madam";

        if (IsPalindrome(word))
            Console.WriteLine($"{word} is a palindrome.");
        else
            Console.WriteLine($"{word} is not a palindrome.");
    }
}