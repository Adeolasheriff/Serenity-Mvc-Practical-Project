using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ToDo.MovieDBS.Pages;

[PageAuthorize(typeof(GenreRow))]
public class GenrePage : Controller
{
    [Route("MovieDBS/Genre")]
    public ActionResult Index()
    {
        return this.GridPage<GenreRow>("@/MovieDBS/Genre/GenrePage");
    }
}