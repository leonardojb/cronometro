using System;

namespace Menu
{
    public class HandlerMenu
    {
        public static void MenuExibition()
        {
            DrawMenu();
            HandleOption();

        }
        public static void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine("           Cronômetro");
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|  m - contagem em minutos.  |");
            Console.WriteLine("|  s - contagem em segundos. |");
            Console.WriteLine("|  0 - Sair da aplicação.    |");
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("");
            Console.WriteLine("Selecione a opção desejada?");

        }

        public static void HandleOption()
        {
            string opcaoSelecionada = Console.ReadLine().ToLower();
            switch (opcaoSelecionada)
            {
                case "x" or "0": Count.HandlerCount.Exit(); break;
                case "s" or "m": Count.HandlerCount.HandleTime(opcaoSelecionada); break;
                default: InvalidOption(); break;
            }

        }

        public static void InvalidOption()
        {
            MenuExibition();
        }

    }
}