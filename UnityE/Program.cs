using System;
using Unity;

namespace UnityE
{
    class Program
    {
        static void Main(string[] args)
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IGame, Trivial>();
            var game = unityContainer.Resolve<IGame>();
            game.AddPlayer();
            game.AddPlayer();

            Console.WriteLine(string.Format("{0} personas jugando a {1},",game.CurrentPlayers, game.Name));
            Console.ReadLine();

            var table = unityContainer.Resolve<Table>();
            table.Play();
            Console.WriteLine(table.GameStatus());
            Console.ReadLine();

        }
    }
}
