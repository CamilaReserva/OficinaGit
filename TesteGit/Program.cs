using System;

Console.WriteLine("Digite um número");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outro numero");
double num1 = Convert.ToDouble(Console.ReadLine());

double resultado = num * num1;

if(resultado == 0) { Console.WriteLine("Número invalido"); }
if(resultado == 1) { Console.WriteLine("Número invalido"); }
if(resultado == 2) { Console.WriteLine("Número invalido"); }
if(resultado == 10) { Console.WriteLine("Número invalido"); }


Console.WriteLine($"O resultado é {resultado}");

Console.ReadKey();