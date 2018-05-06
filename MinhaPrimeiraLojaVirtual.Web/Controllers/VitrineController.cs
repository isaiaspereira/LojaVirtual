using MinhaPrimeiraLoja.Repositorie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaPrimeiraLojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private readonly ProdutoRepository _repositorio = new ProdutoRepository();

        // GET: Produto
        public ActionResult ListarProdutos(int pagina=1)
        {
            int ProdutosPorPagina = 3;
            var ListaDeProdutos = _repositorio.List()
                .OrderBy(n => n.Nome)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);
            //var repository = new ProdutoRepository();
            return View(ListaDeProdutos);
        }
    }
}