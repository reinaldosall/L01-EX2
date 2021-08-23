using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    2- Escreva um programa em Csharp que leia 3 números inteiros e 
    positivos (A B C) do teclado,
    calcule e imprima o valor da expressão.
    */

    Console.WriteLine("Digite o valor inteiro e positivo para A, B e C, respectivamente");
    
    int valorA = int.Parse(Console.ReadLine());
    int valorB = int.Parse(Console.ReadLine());
    int valorC = int.Parse(Console.ReadLine());

    int R = (int)Math.Pow((valorA + valorB), 2);
    int S = (int)Math.Pow((valorB + valorC), 2);

    int result = (R + S) /2;
    
    Console.WriteLine ($"O valor da expressão é D = {result}");
  }
}