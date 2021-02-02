using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Insira o texto:");
  string texto = Console.ReadLine();
  Console.WriteLine("Sua senha é: " + Senha(texto));
  }
  public static string Senha(string texto){
    var vetor = texto.Split();
    int x = vetor.Length;
    int i = 0;
    string senha = "";
    while (i < x){
      senha += vetor[i].Length;
      i++;
    }
    return senha;
  }
}