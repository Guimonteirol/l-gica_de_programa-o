using System; 

class URI {

    static void Main(string[] args) { 
double D;
   int T = int.Parse(Console.ReadLine());
   int Vm = int.Parse(Console.ReadLine());

   D= T*Vm;

  Console.WriteLine((D/12).ToString("F3"));

    }

}