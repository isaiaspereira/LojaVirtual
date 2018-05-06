using MinhaPrimeiraLoja.Repositorie.Repository;
using MinhaPrimeiraLojaVirtual.Domain.Entity;
using MinhaPrimeiraLojaVirtual.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaPrimeiraLojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoRepository _repositorio=new ProdutoRepository();
        
        // GET: Produto
        public ActionResult Index()
        {
            var repository = new ProdutoRepository();
            return View(repository.List());
        }
    }
}