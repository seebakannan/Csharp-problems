using System;
class MainClass {
  public static void Main (string[] args) {
   int num,i, a=0,b;
   Console.WriteLine("enter the number: ");
   num= Convert.ToInt32(Console.ReadLine());
   for (i=1;i<=num; i++){

    if(num%i==0){
      a++;
    }
   }
   if(a==2){
     Console.Write("prime number");

   }
   else{
     Console.WriteLine("not a prime");
   }

  }
}