using System;

Console.WriteLine("Digite um número");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outro numero");
double num1 = Convert.ToDouble(Console.ReadLine());

double resultado = num * num1;

Console.WriteLine($"O resultado é {resultado}");

Console.ReadKey();