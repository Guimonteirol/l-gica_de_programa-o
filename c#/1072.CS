using System; 

class URI {

    static void Main(string[] args) { 

      int X = int.Parse(Console.ReadLine());
  
   int soma = 0;
   int soma1 = 0;
   int i = 1; 
   while(i <= X){
     int num = int.Parse(Console.ReadLine());
     if(num >= 10 && num <= 20){
       soma = 1 + soma; 
       
     }
     else{
       soma1 = 1 + soma1;
        
     }

    i++;
   }
   
   
     Console.WriteLine(soma + " in");
    Console.WriteLine(soma1 + " out");
   

    }

}