using System; 

class URI {

    static void Main(string[] args) { 
        
  string[]vet;

   vet = Console.ReadLine().Split (' ');

    double X1 = double.Parse (vet[0]);
    double Y1 = double.Parse (vet[1]);

     vet = Console.ReadLine().Split (' ');

    double X2 = double.Parse (vet [0]);
    double Y2 = double.Parse (vet[1]);

   double D = Math.Sqrt(Math.Pow((X1-X2),2) + Math.Pow((Y2 - Y1),2));

    Console.WriteLine(D.ToString("F4"));

}
}