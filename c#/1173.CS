using System; 

class URI {

    static void Main(string[] args) { 

       int [] X;
  X = new int[10];
  int i;
  
  
  X[0] = int.Parse(Console.ReadLine());
  
  for(i=1;i<10;i++){
    X[i] = X[i-1] * 2;

  }

  for( i=0;i<10;i++){
    Console.WriteLine("N[" + i + "] = " + X[i]);
  }

    }

}