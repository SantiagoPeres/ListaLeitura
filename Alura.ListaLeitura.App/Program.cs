using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;

namespace Alura.ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new LivroRepositorioCSV();

            IWebHost host = new WebHostBuilder()
                .UseStartup<Startup>()
                .UseKestrel()
                .Build();
            host.Run();

            //    var string1 = "radar";
            //    var result = string1.SequenceEqual(string1.Reverse());

        }

        static void ImprimeLista(ListaDeLeitura lista)
        {
            Console.WriteLine(lista);
        }
    }
}



