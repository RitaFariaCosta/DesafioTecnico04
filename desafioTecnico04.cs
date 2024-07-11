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
          
        Console.WriteLine($"\nInforme os dados do amigo(a) {i + 1} de Inej Ghafa");
        
        Console.Write("Digite o nome do amigo(a): ");
        amigos[i].Nome = Console.ReadLine();
        Console.Write("Digite a idade do amigo(a): ");
        amigos[i].Idade = int.Parse(Console.ReadLine());
        Console.Write("Digite as qualidades do amigo(a): ");
        amigos[i].Qualidade = Console.ReadLine();
    }
    
    Console.WriteLine("\nOs amigos de Inej Ghafa são: ");
    
    for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Amigo(a) {i + 1}: Nome:{amigos[i].Nome}, Idade: {amigos[i].Idade}, Qualidades: {amigos[i].Qualidade}");
        }
  }
}