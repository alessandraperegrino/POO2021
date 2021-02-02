using System;
using static System.Math;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
    var tempo = Console.ReadLine().Split(":");
    ulong h = ulong.Parse(tempo[0]);
    ulong m = ulong.Parse(tempo[1]);
    ulong s = ulong.Parse(tempo[2]);
    ulong distancia = ((h*3600) + (m*60) + s) * 300000;
    Console.WriteLine(h);
    Console.WriteLine(distancia);
    
  }
}