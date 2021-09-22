using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());
  int Y = int.Parse(Console.ReadLine());
  int soma=0;

  if(X<Y){

    for(int i= X + 1;i<Y ;i++){
      
      if(i%2!=0){
        soma = i + soma;
      }   
    }
    Console.WriteLine(soma);
  }

  else if(X>Y){

    for(int i = Y + 1;i < X ;i++){
        
      if(i%2!=0){
        soma = i + soma;
      }
    }
    
    Console.WriteLine(soma);
  }
  else{
    Console.WriteLine("0");
  }

    }

}