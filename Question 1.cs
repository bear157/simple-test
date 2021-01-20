using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {9, 0, 2, 5, 0, 7, 2, 0, 0, 2}; //initial array
        int length = arr.Length; //array length

        for (int i = 0; i < length; i++)
        {
            while(arr[i] == 0) 
            {
                int temp = arr[i];
                for (int j = i; j < length - 1; j++)
                {
                    arr[j] = arr[j+1];
                }//end inner forloop
                arr[--length] = temp;
            }//end while
        }//end outer forloop

        
        for (int k = 0; k < arr.Length; k++)
        {
            Console.WriteLine(arr[k]);
        }

    }
}