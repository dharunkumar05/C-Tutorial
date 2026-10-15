using System;
using System.Collections;
class stackandqueue
{
    static void Main()
    {
        Stack a = new Stack();
        Queue b = new Queue();
        int size = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < size; i++)   
        {
            a.Push(Console.ReadLine());
            b.Enqueue(Console.ReadLine());      
        }   
        a.Pop();
        b.Dequeue();
        foreach(Object obj in a)
        {
            Console.WriteLine(obj);
        }
        foreach(Object obj in b)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine(a.Peek());
        
    }
}