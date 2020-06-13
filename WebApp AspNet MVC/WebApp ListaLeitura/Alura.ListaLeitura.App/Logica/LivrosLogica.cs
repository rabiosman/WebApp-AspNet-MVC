using WebApp.ListaLeitura.App.Negocio;
using WebApp.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApp.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {
        public IEnumerable<Livro> Livros { get; set; }
        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();            
            ViewBag.Livros = _repo.ParaLer.Livros;       
            return View("Lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("Lista");            
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("Lista");
        }
        public string Detalhes(int id)
        {            
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }       
    }
}
