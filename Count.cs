using System;

namespace Count
{
    public class HandlerCount
    {
        public static void HandleTime(string opcaoSelecionada)
        {
            Console.Clear();
            Console.WriteLine("Quantos time deseja contar?");
            string time = Console.ReadLine();
            int selectedTime = int.Parse(time);

            switch (opcaoSelecionada)
            {
                case "s": Count.HandlerCount.Start(selectedTime); break;
                case "m": Count.HandlerCount.Start(selectedTime * 60); break;
            }
        }

        public static void Start(int time)
        {
            Console.Clear();
            Console.WriteLine($"Cronometrô setado para {time} segundos.");
            Thread.Sleep(1000);
            Console.WriteLine("Começando em 3.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Cronometrô setado para {time} segundos.");
            Console.WriteLine("Começando em 2..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Cronometrô setado para {time} segundos.");
            Console.WriteLine("Começando em 1...");
            Thread.Sleep(1000);
            Console.Clear();

            CountSeconds(time);
            Stop();
        }

        public static void Stop()
        {
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            Menu.HandlerMenu.MenuExibition();
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("O programa está sendo encerrado.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("O programa está sendo encerrado..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("O programa está sendo encerrado...");
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }

        public static void CountSeconds(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}
