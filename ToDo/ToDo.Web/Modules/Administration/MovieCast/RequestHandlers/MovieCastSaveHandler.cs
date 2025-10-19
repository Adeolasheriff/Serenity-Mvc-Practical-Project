using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.Administration.MovieCastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.Administration.MovieCastRow;

namespace ToDo.Administration;

public interface IMovieCastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieCastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastSaveHandler
{
    public MovieCastSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}