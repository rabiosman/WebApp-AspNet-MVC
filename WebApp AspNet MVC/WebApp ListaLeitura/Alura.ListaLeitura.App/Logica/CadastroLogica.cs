using WebApp.ListaLeitura.App.Negocio;
using WebApp.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.ListaLeitura.App.Logica
{
    public class CadastroController
    {        
        public IActionResult ExibeFormulario()
        {
            var html = new ViewResult {ViewName = "formulario" };
            return html;
        }
        public string Incluir(Livro livro)
        {            
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return "Novo livro adicionado!";
        }        
    }
}
