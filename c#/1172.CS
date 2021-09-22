using System; 

class URI {

    static void Main(string[] args) { 
int[] B;
   B = new int [10];

   for(int i=0; i<10; i++){
     B[i] = int.Parse(Console.ReadLine());
     if(B[i] <= 0){
       B[i] = 1;
     }
   }
   for(int i=0; i<10; i++){
     Console.WriteLine("X[" + i + "] = " + B[i] );
   }
    
 

    }

}