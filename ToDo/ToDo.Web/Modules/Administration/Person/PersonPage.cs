using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ToDo.Administration.Pages;

[PageAuthorize(typeof(PersonRow))]
public class PersonPage : Controller
{
    [Route("Administration/Person")]
    public ActionResult Index()
    {
        return this.GridPage<PersonRow>("@/Administration/Person/PersonPage");
    }
}