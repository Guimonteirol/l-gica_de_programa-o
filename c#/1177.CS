using System; 

class URI {

    static void Main(string[] args) { 
 int X = int.Parse(Console.ReadLine());
    int[] vet = new int [1000];

    for(int i = 0; i < 1000; i++){
      vet[i] = i % X;
    }

   for(int i = 0; i < 1000; i++){
     Console.WriteLine("N[" + i + "] = " + vet[i]);
   }

    }

}