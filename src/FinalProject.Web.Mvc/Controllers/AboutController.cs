using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using FinalProject.Controllers;

namespace FinalProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : FinalProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
