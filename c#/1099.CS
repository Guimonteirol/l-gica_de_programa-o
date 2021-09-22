using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());
   string[]vet;
   
  
 
   for(int i = 1;i <= X; i++){
    vet = Console.ReadLine().Split (' ');
  
    int Y = int.Parse(vet[0]);
    int Z = int.Parse(vet[1]);
    int soma = 0;
       if(Y < Z){
       for(int u = Y + 1; u < Z; u++ ){
          if(u % 2 !=0){
          soma += u ;
          
         
          }  
        }
      }
       else {
        for(int v = Z + 1; v < Y; v++ ){
          if(v % 2 != 0){
          soma = v + soma;
          
         
          }
        }
      }
    
   Console.WriteLine(soma);     
   }


    }

}