using System; 

class URI {

    static void Main(string[] args) { 

       int A, M,D;
 int N = int.Parse(Console.ReadLine());
 
 A= N/365;
 M= (N%365)/30;
 D= ((N%365)%30)/1;

 Console.WriteLine(A + " ano(s)");
 Console.WriteLine(M + " mes(es)");
 Console.WriteLine(D + " dia(s)");

    }

}