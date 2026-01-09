using System;
class userarray{
	static void Main(){
		int sum=0;
		int[] a=new int[Convert.ToInt32(Console.ReadLine())];
		for(int i=0;i<a.Length;i++){
			a[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0;i<a.Length;i++){
			Console.WriteLine("a[{0}] = {1}",i,a[i]);
			sum+=a[i];
		}
		Console.WriteLine(sum);
		
	}

}

