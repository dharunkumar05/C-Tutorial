using System;

using System.Collections.Generic;

class GEnericcollections
{
    static void Main()
    {
        /*List<int> a = new List<int>();
        int size = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            a.Add(Convert.ToInt32(Console.ReadLine()));

        }
        Console.Write("the elements in the list are : ");
        foreach(int i in a)
        {
            Console.Write(i +" ");
        }
        Console.Write("Removing elemnts in the list using index:");
        a.RemoveAt(0);
        a.RemoveRange(0,4);
        for(int i =0;i< a.Count; i++)
        {
            if (a.Contains(3))
            {
                a.Remove(a[i]);
            }
        }*/
        HashSet<String> hs = new HashSet<String>();
        int size = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < size; i++)
        {
            string input = Console.ReadLine() ?? "";
            hs.Add(input);
        }   
        Console.Write("the elements in the hashset are : ");
        foreach(String i in hs)
        {
            Console.Write(i +" ");
        }
    }
}