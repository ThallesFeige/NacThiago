using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rm82099.Nac1.Bruno.Web.Models;
using Rm82099.Nac1.Bruno.Web.Persistencia;

namespace Rm82099.Nac1.Bruno.Web.Controllers
{
    public class MercadoController : Controller
    {

        private marketContext _context;

        public MercadoController(marketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lista = _context.Mercadinhos.ToList();
            return View(lista); 
        }

        [HttpGet]
        public IActionResult Pesquisar(string nome)
        {
            var lista = _context.Mercadinhos.Where(l => l.Nome.Contains(nome)).OrderBy(l => l.Porte).ToList();
            return View("Index", lista);
        }


        [HttpPost]
        public IActionResult Remover(int id)
        {
            var mercado = _context.Mercadinhos.Find(id);
            _context.Mercadinhos.Remove(mercado);
            _context.SaveChanges();
            TempData["msg"] = "Mercado Removidoow :( ";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Mercado mercado)
        {
            _context.Mercadinhos.Update(mercado);
            _context.SaveChanges();
            TempData["msg"] = "Mercado Atualizado ;) ";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            var mercado = _context.Mercadinhos.Find(id);
            return View(mercado);
        }

        [HttpGet] 
        public IActionResult Cadastrar()
        {
            return View(); 
        }

        
        [HttpPost]
        public IActionResult Cadastrar(Mercado mercado)
        {
            
            _context.Mercadinhos.Add(mercado);

            _context.SaveChanges(); 
       
            TempData["msg"] = "Mercado registrada!";
           
            return RedirectToAction("Cadastrar");
        }

    }
}
