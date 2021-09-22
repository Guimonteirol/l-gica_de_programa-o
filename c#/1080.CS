using System; 

class URI {

    static void Main(string[] args) { 
  int N = int.Parse(Console.ReadLine());
    int[] X = new int[N];
    int menor = 999;
    int pos = 0;
    
    string[] vet = new string[N];
    vet = Console.ReadLine().Split(' ');

    for(int i = 0; i < N; i++){
      X[i] = int.Parse(vet[i]);
      if(X[i] < menor){
        menor = X[i];
        pos = i;
      }
    }
   for(int i = 0; i < 1; i++){
     Console.WriteLine("Menor valor: " + menor);
     Console.WriteLine("Posicao: " + pos);
   }
    

    }

}