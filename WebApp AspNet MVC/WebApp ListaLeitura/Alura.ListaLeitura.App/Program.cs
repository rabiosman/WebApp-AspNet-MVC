using WebApp.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Hosting;

namespace WebApp.ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new LivroRepositorioCSV();
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();            
        }        
    }
}
