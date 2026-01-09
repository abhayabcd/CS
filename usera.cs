using System;
class usera{
	static void Main(){
		int[] a=new int[4];
		for(int i=0;i<a.Length;i++){
			a[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0;i<a.Length;i++){
			Console.WriteLine(a[i]);
		}
	}
}