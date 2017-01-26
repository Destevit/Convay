using Convay.Core;
using Convay.Core.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleConvay
{
    class Program
    {

        static void Main(string[] args)
        {
            int width;
            Console.Write("Podaj szerokość siatki: ");
            if(!int.TryParse(Console.ReadLine(), out width))
            {
                Error("zła szerokość");
            }
            int height;
            Console.Write("Podaj wysokość siatki: ");
            if(!int.TryParse(Console.ReadLine(), out height))
            {
                Error("zła wysokość");
            }
            IRules rules = null;
            Console.Write("Podaj zasady: ");
            try
            {
                rules = new StringRules(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
            IGame game = new Game(
                new ParallelEngine(),
                new ByteGrid(width, height),
                rules,
                new TimeSpan(0, 0, 0, 0, 100)
                );
            game.Randomize();
            game.GridChanged += WriteGrid;
            Console.Write("Naciśnij klawisz by wystartować");
            Console.ReadKey();
            game.Start();
            Console.ReadKey();
        }

        private static void WriteGrid(object sender, GridChangedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine(e.Grid);
        }

        static void Error(string msg = "Błąd")
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
