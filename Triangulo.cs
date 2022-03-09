using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosDeCodigo
{
	/*
    Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo.

    Em caso positivo, calcule o perímetro do triângulo (soma de todos os lados) e apresente a mensagem:

    Perimetro = XX.X
    
    Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem:

    Area = XX.X
    
    Fórmula da área de um trapézio: AREA = ((A + B) x C) / 2
    
    .:: Entrada ::.
    A entrada contém três valores reais.

    .:: Saída ::.
    O resultado deve ser apresentado com uma casa decimal.
    
    Exemplo de Entrada 	Exemplo de Saída
        6.0 4.0 2.0   |   Area = 10.0

        6.0 4.0 2.1   |   Perimetro = 12.1
    */
	public class Triangulo
	{
		static void Main(string[] args)
		{

			double a, b, c;
			string[] valor = Console.ReadLine().Split(' ');
			a = Convert.ToDouble(valor[0]);
			b = Convert.ToDouble(valor[1]);
			c = Convert.ToDouble(valor[2]);

			if (a < b + c && b < a + c && c < a + b)
			{
				Console.WriteLine($"Perimetro = {Math.Round(((a + b + c) / 10), 1).ToString("F1")}");
			}
			else
			{
				Console.WriteLine($"Area = {Math.Round(((((a + b) * c) / 2) / 100), 1).ToString("F1")}");
			}

			// static bool IsTriangle(double a, double b, double c)
			// {
			// 	if (a < b + c && b < a + c && c < a + b)
			// 	{
			// 		return true;
			// 	}
			// 	else
			// 	{
			// 		return false;
			// 	}
			// }
			// static double Perimeter(double a, double b, double c)
			// {
			// 	return a + b + c;
			// }
			// static double Area(double a, double b, double c)
			// {
			// 	return ((a + b) * c) / 2;
			// }

			// if (IsTriangle(a, b, c))
			// {
			// 	Console.WriteLine("Perimetro = {0:F1}", (Perimeter(a, b, c) / 10));
			// }
			// else
			// {
			// 	Console.WriteLine("Area = {0:F1}", (Area(a, b, c) / 100));
			// }
		}
	}
}