using System;
using System.Reflection;
using System.Threading;
namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Iniciar();
    }
    static void Iniciar()
    {
      Console.Clear();
      int multiplicador = 1;
      Console.WriteLine("Digite o número em minutos ou em segundos (Ex.1m ou 5s): ");
      string valor = Console.ReadLine()!.ToLower();
      char tipo = char.Parse(valor.Substring(valor.Length - 1, 1));
      int time = int.Parse(valor.Substring(0, valor.Length - 1));
      if (tipo == 'm')
        multiplicador = 60;
      if (time == 0)
        System.Environment.Exit(0);

      Contador(time * multiplicador);
    }
    static void Contador(int time)
    {
      Console.Clear();
      Preparacao();
      int contador = 0;
      while (contador != time)
      {
        Console.Clear();
        contador++;
        Console.WriteLine(contador);
        Thread.Sleep(1000);
      }
    }
    static void Preparacao()
    {
      Console.Write("Preparar...");
      Thread.Sleep(1000);
      Console.Clear();

      Console.Write("Apontar...");
      Thread.Sleep(1000);
      Console.Clear();

      Console.Write("Vai!!!");
      Thread.Sleep(1800);
      Console.Clear();

    }
  }
}