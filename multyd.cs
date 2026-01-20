using System;
class multyd{
	static void Main(){
		int[,] a = new int[2,3];
		a[0,0] =10;
		a[0,1] =20;
		a[0,2] =30;
		a[1,0] =40;
		a[1,1] =50;
		a[1,2] =60;
		Console.WriteLine("Total Element of array is "+a.Length);
		Console.WriteLine("Total Element of Row is "+a.GetLength(0));
		Console.WriteLine("Total Element of column is "+a.GetLength(1));
		for(int i=0;i<a.GetLength(0);i++){
			for(int j=0;j<a.GetLength(1);j++){
				Console.WriteLine("a[{0},{1}] = {2}",i,j,a[i,j]);
			}
		}
	}
}