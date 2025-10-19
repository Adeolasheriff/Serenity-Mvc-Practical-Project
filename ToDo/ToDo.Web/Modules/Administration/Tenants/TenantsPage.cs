using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ToDo.Administration.Pages;

[PageAuthorize(typeof(TenantsRow))]
public class TenantsPage : Controller
{
    [Route("Administration/Tenants")]
    public ActionResult Index()
    {
        return this.GridPage<TenantsRow>("@/Administration/Tenants/TenantsPage");
    }
}