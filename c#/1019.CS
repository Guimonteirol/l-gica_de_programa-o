using System; 

class URI {

    static void Main(string[] args) { 

     int H, h,mm,S, M; 
  int N = int.Parse(Console.ReadLine());
   H = N/3600;
   h= N%3600;
   M= h/60;  
   mm= h%60;
   S= mm/1;
    Console.WriteLine(H+ ":" + M +":"+ S);

    }

}