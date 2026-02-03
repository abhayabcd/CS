using System;
class Jegged
{
    static void Main()
    {
	Console.WriteLine("Enter Dimension : ");
        int[][][] a = new int[Convert.ToInt32(Console.ReadLine())][][];
	
        for (int i = 0; i < a.Length; i++)
        {
		Console.WriteLine("Enter {0} Dimension's Row Number : ",i);
		a[i]=new int[Convert.ToInt32(Console.ReadLine())][];
 		for (int j = 0; j < a[i].Length; j++)
        	{
			Console.WriteLine("Enter {0} Dimension's {1} Row's Column Number : ",i,j);
			a[i][j]=new int[Convert.ToInt32(Console.ReadLine())];
		}
	}
	
        for (int i = 0; i < a.Length; i++)
        {
         	for (int j = 0; j < a[i].Length; j++)
       		{ 
			for (int k = 0; k < a[i][j].Length; k++)
            		{
                		Console.Write("a[{0}][{1}][{2}] =   ", i, j, k);
                		a[i][j][k] = Convert.ToInt32(Console.ReadLine());
            		}
		}
		Console.WriteLine();
        }

        for (int i = 0; i < a.Length; i++)
        {
         	for (int j = 0; j < a[i].Length; j++)
       		{ 
			for (int k = 0; k < a[i][j].Length; k++)
            		{
                		Console.Write("a[{0}][{1}][{2}] = {3}  ", i, j, k, a[i][j][k]);
            		}
			 Console.WriteLine();	
		}
		 Console.WriteLine();	
        }
}
}