using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, D, E, F, G;
  int N = int.Parse(Console.ReadLine());
   
    A = N/100;
    B = (N%100)/50;
    C = ((N%100)%50)/20;
    D = (((N%100)%50)%20)/10;
    E = ((((N%100)%50)%20)%10)/5;
    F = (((((N%100)%50)%20)%10)%5)/2;
    G = ((((((N%100)%50)%20)%10)%5)%2)/1;

    Console.WriteLine(N);
     Console.WriteLine(A + " nota(s) de R$ 100,00");
     Console.WriteLine(B + " nota(s) de R$ 50,00");
     Console.WriteLine(C + " nota(s) de R$ 20,00");
     Console.WriteLine(D + " nota(s) de R$ 10,00");
     Console.WriteLine(E + " nota(s) de R$ 5,00");
     Console.WriteLine(F + " nota(s) de R$ 2,00");
     Console.WriteLine(G + " nota(s) de R$ 1,00");



    }

}