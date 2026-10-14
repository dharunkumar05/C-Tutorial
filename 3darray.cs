using System;

class Threedarray
{
    static void Main()
    {
        Console.Write("Enter the no. of rows :");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the no. of columns");
        int col = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the no. of layers");
        int layer = Convert.ToInt32(Console.ReadLine());
        int [,,] arr = new int[row,col,layer];
        for(int i = 0; i < layer; i++)
        {
            for(int j = 0; j < row; j++)
            {
                for(int k=0;k< col; k++)
                {
                    Console.Write("Enter the element :");
                    arr[i,j,k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        int max = arr[0,0,0];
        int sum = 0;
        for (int i = 0; i < layer; i++)
        {
            for(int j =0; j < row; j++)
            {
                for(int k = 0; k < col; k++)
                {
                    sum+=arr[i,j,k];
                    if (arr[i, j, k] > max)
                    {
                        max = arr[i,j,k];
                    }
                }
            }
        }
        Console.WriteLine("Sum is " + sum + "\n" + "max is " + max);

    }
}