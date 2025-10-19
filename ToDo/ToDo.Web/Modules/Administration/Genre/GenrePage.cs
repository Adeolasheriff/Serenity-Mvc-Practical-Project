using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ToDo.Administration.Pages;

[PageAuthorize(typeof(GenreRow))]
public class GenrePage : Controller
{
    [Route("Administration/Genre")]
    public ActionResult Index()
    {
        return this.GridPage<GenreRow>("@/Administration/Genre/GenrePage");
    }
}