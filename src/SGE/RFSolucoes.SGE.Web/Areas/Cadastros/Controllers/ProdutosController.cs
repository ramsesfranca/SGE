using Microsoft.AspNetCore.Mvc;
using RFSolucoes.SGE.Dominio.Entidades.Cadastros;
using RFSolucoes.SGE.Dominio.Interfaces.Servicos.Cadastros;
using RFSolucoes.SGE.Web.Areas.Cadastros.Models.Produtos;
using RFSolucoes.SGE.Web.Controllers;
using System.Threading.Tasks;

namespace RFSolucoes.SGE.Web.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class ProdutosController : BaseController
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutosController(IProdutoServico produtoServico)
        {
            this._produtoServico = produtoServico;
        }

        #region GETs

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inserir()
        {
            return View();
        }

        public IActionResult Alterar()
        {
            return View();
        }

        public IActionResult Visualizar()
        {
            return View();
        }

        #endregion

        #region POSTs

        [HttpPost]
        public async Task<IActionResult> Inserir(FormularioProdutoModel modelo)
        {
            this._produtoServico.Inserir(new Produto
            {
                Nome = modelo.Nome,
                CodigoInterno = modelo.CodigoInterno
            });

            return View();
        }

        #endregion
    }
}
