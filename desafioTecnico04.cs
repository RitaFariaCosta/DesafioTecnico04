using System;
class HelloWorld {
    
  public struct Amigos {
      public string Nome;
      public int Idade;
      public string Qualidade;
  }    
  
  static void Main() {
      Amigos[] amigos = new Amigos[3];
      
      for(int i = 0; i < 3; i++){
        Console.WriteLine($"\nInforme os dados do amigo(a) {i + 1}");
         
        Console.Write("Digite o nome do amigo(a): ");
        amigos[i].Nome = Console.ReadLine();
        Console.Write("Digite a idade do amigo(a): ");
        amigos[i].Idade = int.Parse(Console.ReadLine());
        Console.Write("Digite as qualidades do amigo(a): ");
        amigos[i].Qualidade = Console.ReadLine();
    }
    
    for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nAmigo(a) {i + 1}: {amigos[i].Nome}, {amigos[i].Idade}, {amigos[i].Qualidade}");
        }
  }
}