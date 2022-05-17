using System;

namespace csharp_banca_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca MiaBanca = new Banca("Banca BCC");
            Cliente cliente = new Cliente("Mario", "Rossi", "ccccccc", 1200);
            Console.WriteLine(cliente.ToString());

        }
    }
}