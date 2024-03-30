using System;
using System.Threading; //esse comando permite o uso do threading na linha 23, na função Start()

namespace Stopwatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("S = Segundo  || 10s => 10 segundos");
            System.Console.WriteLine("M = Minuto   ||  1m =>  1 minuto");
            System.Console.WriteLine("0 = Sair");
            System.Console.WriteLine("Quanto tempo voçê quer contar?");

            string data = Console.ReadLine().ToLower();   //Aqui o ToLower irá converter tudo pra minusculo
            char type = char.Parse(data.Substring(data.Length -1,1));  //Aqui o substring pega o caractere na posicao, determinada dentro do parentes, nesse caso ele está usando o primeiro caractere de tráz pra frente determinado pelo Length
            int time = int.Parse(data.Substring(0, data.Length -1)); //Nese caso ele ira imprimir todos os caracteres desde o 0 até o -1
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);
            
            PreStart(time*multiplier);
        }

        static void PreStart( int time)   //Aqui é só uma firula antes de iniciar o contador
        {
            Console.Clear();
            System.Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Set...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void  Start( int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);  // esse comando vai dizer pro processador da thread dormir por  1000 milissegundo;
            }

            Console.Clear();
            System.Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(2000);
        }
    }
}