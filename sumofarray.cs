using System;

class maximumof2darray{
        static void Main()
    {   
        Console.Write("Enter the the no.of rows ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the the no.of columns ");
        int col = Convert.ToInt32(Console.ReadLine());
        int [,] arr = new int[row,col];
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                Console.Write("Enter the element:");
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int max = arr[0,0];
        int sum = 0;
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                sum+=arr[i,j];
                if(arr[i,j] > max)
                {
                    max = arr[i,j];
                }
            }
        }
        Console.WriteLine("sum is " + sum); 
        Console.WriteLine("max is "+ max);
    }
}