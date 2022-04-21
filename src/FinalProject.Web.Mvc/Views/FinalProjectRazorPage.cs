using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FinalProject.Web.Views
{
    public abstract class FinalProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FinalProjectRazorPage()
        {
            LocalizationSourceName = FinalProjectConsts.LocalizationSourceName;
        }
    }
}
