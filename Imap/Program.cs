using System;
using StructureMap;

namespace Imap
{
    class Program
    {
        static void Main(string[] args)
        {
            var objeto1 = Contenedor.InitContainer().GetInstance<IMensaje>();
            var mensaje = objeto1.GetMensagge();
            Console.WriteLine(mensaje);
        }
    }
}
