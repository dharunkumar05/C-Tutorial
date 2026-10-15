using System;
using System.Collections;

class Nonegenericcollection
{
    static void Main()
    {
        ArrayList arr = new ArrayList();
        int size = Convert.ToInt32(Console.ReadLine());
        /*for (int i =0;i< size ; i++)
        {
            arr.Add(Console.ReadLine());
        }
        foreach(Object obj in arr)
        {
            Console.WriteLine(obj);
        }*/
        /*Console.WriteLine(arr.Count);
        Console.WriteLine(arr.Capacity);
        arr.RemoveRange(0,1);
        arr.AddRange(new object[] {"A",3,22.22});
        foreach(Object obj in arr)      
        {
            Console.WriteLine(obj);
        }*/
        Hashtable ht = new Hashtable();
        for (int i = 0; i < size; i ++)
        {
            ht.Add(i,Console.ReadLine());
        }
        foreach(DictionaryEntry obj in ht)
        {
            Console.WriteLine(obj.Key + " " + obj.Value);
        }
        /*for(int i = 0; i < size;i++){
            if (arr.Contains("chennai"))
            {
                arr.Remove(arr[i]);
            }
        }
        Console.WriteLine("After removing chennai");
        foreach(Object obj in arr)
        {
            Console.WriteLine(obj);
        }
        */
        for (int i = 0; i < size; i++)
        {
            if (ht.ContainsValue("chennai"))
            {
                ht.Remove(i);
            }
        }
        Console.WriteLine("After removing chennai");
        foreach(DictionaryEntry obj in ht)
        {
            Console.WriteLine(obj.Key + " " + obj.Value);
        }

    }
}