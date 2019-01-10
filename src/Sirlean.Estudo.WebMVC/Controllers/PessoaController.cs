using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sirlean.Estudo.WebMVC.Models;

namespace Sirlean.Estudo.WebMVC.Controllers
{
    public class PessoaController : Controller
    {
        #region Simulacao
        private static List<Pessoa> pessoas;

        public PessoaController()
        {
            if (pessoas == null)
            {
                pessoas = new List<Pessoa>();
                pessoas.Add(new Pessoa() { Codigo = 1, Nome = "Sirlean", Email = "sirlean@fauldkfj.com", DataNascimento = DateTime.Now });
            }
        }

        private Pessoa PesquisarPessoa(int id)
        {
            return pessoas.Single(p => p.Codigo == id);
        }

        private void AdicionarPessoa(Pessoa pessoa)
        {
            pessoas.OrderBy(p => p.Codigo);
            pessoa.Codigo = pessoas.Last().Codigo + 1;
            pessoas.Add(pessoa);
        }

        private void AtualizarPessoa(Pessoa pessoa)
        {
            pessoas.RemoveAll(p => p.Codigo == pessoa.Codigo);
            pessoas.Add(pessoa);
        }

        private static void RemoverPessoa(int id)
        {
            pessoas.RemoveAll(p => p.Codigo == id);
        }

        private List<Pessoa> PesquisarPessoaTodos()
        {
            return pessoas;
        }

        #endregion

        #region Gets das Views

        // GET: Pessoa
        public ActionResult Index()
        {
            List<Pessoa> lista = PesquisarPessoaTodos();
            return View(pessoas);
        }
        
        // GET: Pessoa
        public ActionResult Create()
        {
            return View();
        }

        // GET: Pessoa
        public ActionResult Delete(int id)
        {
            Pessoa pessoa = PesquisarPessoa(id);
            return View(pessoa);
        }

        // GET: Pessoa
        public ActionResult Details(int id)
        {
            Pessoa pessoa = PesquisarPessoa(id);
            return View(pessoa);
        }

        // GET: Pessoa
        public ActionResult Edit(int id)
        {
            Pessoa pessoa = PesquisarPessoa(id);
            return View(pessoa);
        }
        #endregion

        #region Posts das Views

        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            AdicionarPessoa(pessoa);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            AtualizarPessoa(pessoa);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Delete(int id, string qualquercoisa)
        {
            RemoverPessoa(id);
            return RedirectToAction("Index");
        }

        #endregion
    }
}