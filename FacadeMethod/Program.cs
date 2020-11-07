using System;

namespace FacadeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("pique macho", 55);
            client.MakeOrder();

        }
    }
}
