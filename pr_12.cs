using System;
class userarray{
	static void Main(){
		int[,] a=new int[Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())];
		for(int i=0;i<a.GetLength(0);i++){
			for(int j=0;i<a.GetLength(1);i++){
				a[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		for(int i=0;i<a.GetLength(0);i++){
			for(int j=0;i<a.GetLength(1);i++){
				Console.Write("a[{0},{1}] = {2}",i,j,a[i,j]);
			}
			Console.WriteLine();
		}
	}
}