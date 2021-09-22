using System; 

class URI {

    static void Main(string[] args) { 

       int i;
    double[] vet;
    vet = new double[100];

    for(i=0;i<100;i++){
     vet[i] = double.Parse(Console.ReadLine());

    }

    for(i=0;i<100;i++){
      if(vet[i] <= 10){
        Console.WriteLine("A[" + i +"] = " + vet[i].ToString("F1") );

      }
    }


    }

}