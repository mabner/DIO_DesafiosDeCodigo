using System;

    class MinhaClasse {
        static void Main(string[] args) {
            var timeInSeconds = int.Parse(Console.ReadLine());
            var hours = (timeInSeconds / 3600); 
            var minutes = (timeInSeconds % 3600) / 60; 
            var seconds = (timeInSeconds % 3600) % 60;
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
