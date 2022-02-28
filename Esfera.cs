using System;

class DIO
{
	static void Main(string[] args)
	{
		double pi, raio, volume;
		pi = 3.14159;

		raio = int.Parse(Console.ReadLine());

		//escreva o seu código
		volume = (4.0 * pi * (Math.Pow(raio, 3.0))) / 3.0;
		Console.WriteLine("VOLUME = " + Math.Round(volume, 3).ToString("F3"));
	}
}