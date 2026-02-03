using System;
class ifelse{
	static void Main(String[] a){
		int n=Convert.ToInt32(Console.ReadLine());
		if(n>0){
			Console.Write("Number is Positive");
		}
		else if(n<0){
			Console.Write("Number is Nagative");
		}
		else{
			Console.Write("Number is Zero");
		}
	}
}