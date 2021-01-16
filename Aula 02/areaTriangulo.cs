using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a área da base:");
    double b = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a altura:");
    double h = int.Parse(Console.ReadLine());
    double area = b*h/2;
    Console.WriteLine(area);
}
}