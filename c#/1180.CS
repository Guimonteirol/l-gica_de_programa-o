using System; 

class URI {

 
   static void Main(string[] args) { 

         int A, i;
  int pos = 0;
  int maior = -999;

  for(i = 1; i<= 100; i++){
    A = int.Parse(Console.ReadLine());

    if(A > maior){
      maior = A;
      pos = i;
    }
  }
      
   
    Console.WriteLine(maior);
    Console.WriteLine(pos);
    
  

   }
}