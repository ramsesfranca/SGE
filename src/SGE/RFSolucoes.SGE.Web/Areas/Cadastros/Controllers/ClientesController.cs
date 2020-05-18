using Microsoft.AspNetCore.Mvc;
using RFSolucoes.SGE.Web.Controllers;

namespace RFSolucoes.SGE.Web.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class ClientesController : BaseController
    {
        #region GETs

        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
