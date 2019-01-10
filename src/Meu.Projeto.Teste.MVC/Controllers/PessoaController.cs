using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meu.Projeto.Teste.MVC.Models;

namespace Meu.Projeto.Teste.MVC.Controllers
{
    public class PessoaController : Controller
    {
        private static List<Pessoa> pessoas = new List<Pessoa>(
            new Pessoa[]
            {
                 new Pessoa {
                     Codigo = 1,
                     Nome = "Sirlean",
                     Email = "Sirlean@sirlean.com",
                     DataNascimento = DateTime.Parse("1987-02-08"),
                     Telefone = "11999995487"
                 }
            });

        #region GET

        // GET: Pessoa
        public ActionResult Index()
        {
            return View(pessoas);
        }
        public ActionResult Create()
        {
            var pessoa = new Pessoa();
            pessoa.Codigo = pessoas.OrderBy(p => p.Codigo).Last().Codigo + 1;
            return View(pessoa);
        }
        public ActionResult Edit(int id)
        {
            var pessoa = pessoas.Single(p => p.Codigo == id);
            return View(pessoa);
        }

        public ActionResult Delete(int id)
        {
            var pessoa = pessoas.Single(p => p.Codigo == id);
            return View(pessoa);
        }

        public ActionResult Details(int id)
        {
            var pessoa = pessoas.Single(p => p.Codigo == id);
            return View(pessoa);
        }

        #endregion
        #region POST

        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            pessoas.RemoveAll(p => p.Codigo == pessoa.Codigo);
            pessoas.Add(pessoa);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id, string qualquercoisa)
        {
            pessoas.RemoveAll(p => p.Codigo == id);
            return RedirectToAction("Index");
        }

        #endregion
    }
}
