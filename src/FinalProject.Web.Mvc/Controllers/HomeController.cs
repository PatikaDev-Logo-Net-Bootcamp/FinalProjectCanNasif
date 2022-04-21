using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using FinalProject.Controllers;

namespace FinalProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FinalProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
