using Abp.AspNetCore.Mvc.ViewComponents;

namespace FinalProject.Web.Views
{
    public abstract class FinalProjectViewComponent : AbpViewComponent
    {
        protected FinalProjectViewComponent()
        {
            LocalizationSourceName = FinalProjectConsts.LocalizationSourceName;
        }
    }
}
