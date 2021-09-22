using System; 

class URI {

    static void Main(string[] args) { 

       int i;
    int[] vet;
    int[] X;
    vet = new int[20];
    X = new int[20];
    for(i = 0; i < 20; i++){
      vet[i] = int.Parse(Console.ReadLine());
      
    }

    for( i = 0; i < 20; i++){
      X[19 - i] = vet[i];
      
    }

    for( i = 0; i < 20; i++){
       Console.WriteLine("N[" + i + "] = " + X[i]);
    }



    }

}