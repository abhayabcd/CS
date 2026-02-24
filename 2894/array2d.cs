using System;
class array2d{
	static void Main(){
		int r=Convert.ToInt32(Console.ReadLine());
		int c=Convert.ToInt32(Console.ReadLine());
		int count=0;
		bool [,]index=new bool[r,c];
		int [,]a = new int[r,c];
		for(int i=0;i<r;i++){
			for(int j=0;j<c;j++){
				Console.WriteLine("Enter a[{0},{1}] : ",i,j);
				a[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		for(int i=0;i<r;i++){
			for(int j=0;j<c;j++){
				Console.Write("a[{0},{1}] : {2}  ",i,j,a[i,j]);
			}
			Console.WriteLine();
		}
		for(int i=0;i<r;i++){
			for(int j=0;j<c;j++){
				if(index[i,j]){continue;}
				for(int k=0;k<r;k++){
					for(int l=0;l<c;l++){
						if(a[i,j] == a[k,l]){
							count++;
							index[k,l]=true;
						}	
					}
				}
				if(count>1){
					Console.WriteLine("{0} repeted {1} time",a[i,j],count);
				}
				count=0;
			}
		}
	}
}