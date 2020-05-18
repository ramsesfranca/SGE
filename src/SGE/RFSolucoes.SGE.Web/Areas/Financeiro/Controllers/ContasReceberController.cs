using Microsoft.AspNetCore.Mvc;
using RFSolucoes.SGE.Web.Controllers;

namespace RFSolucoes.SGE.Web.Areas.Financeiro.Controllers
{
    [Area("Financeiro")]
    public class ContasReceberController : BaseController
    {
        #region GETs

        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
