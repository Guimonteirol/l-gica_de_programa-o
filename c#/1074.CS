using System; 

class URI {

    static void Main(string[] args) { 
int num = int.Parse(Console.ReadLine());

  int i = 0;
  while(i < num){
    int num1 = int.Parse(Console.ReadLine());
    if(num1!= 0){
      if(num1 % 2 == 0){
       Console.Write("EVEN ");
      }
      else{
        Console.Write("ODD " );
      }
  
      if(num1 > 0){
       Console.WriteLine("POSITIVE");
      }
      else if(num1 < 0){
        Console.WriteLine("NEGATIVE");
      }
    }
    else{
      Console.WriteLine("NULL");
    }
    i++;
  }

    }

}