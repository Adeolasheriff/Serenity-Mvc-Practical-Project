using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ToDo.Administration.Pages;

[PageAuthorize(typeof(MovieRow))]
public class MoviePage : Controller
{
    [Route("Administration/Movie")]
    public ActionResult Index()
    {
        return this.GridPage<MovieRow>("@/Administration/Movie/MoviePage");
    }
}