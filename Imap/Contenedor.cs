using StructureMap;

namespace Imap
{
    internal class Contenedor
    {
        internal static IContainer InitContainer()
        {
            var container = new Container(c => c.For<IMensaje>().Use<Mensaje1>());
            return container;

        }
    }
}
