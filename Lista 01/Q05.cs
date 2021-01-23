using System;
using static System.Math;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a base e a altura do triângulo:");
    double b = double.Parse(Console.ReadLine ());
    double h = double.Parse(Console.ReadLine ());
    Console.Write("Área: " + string.Format("{0:0.00}", b*h) + " - Perímetro: " + string.Format("{0:0.00}", b*2+h*2)+ " - Diagonal: " + string.Format("{0:0.00}", Math.Sqrt(h*h+b*b)));

  }
}