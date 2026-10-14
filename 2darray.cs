using System;

class Maximum
{
    static void Main()
    {
        Console.Write("enter the size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter the element:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0];
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > max){
                max = arr[i];
            }
        }
        Console.WriteLine("maxi is " + max);
        for(int i = 0; i < n; i++)
        {
            if(arr[i]%2 == 0)
            {
                Console.WriteLine(arr[i] + " is even");
            }
            else 
            
            {
                Console.WriteLine(arr[i] + " is odd");
            }
        }
    }
}