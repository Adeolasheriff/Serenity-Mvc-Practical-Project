using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.Administration.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.Administration.MovieRow;

namespace ToDo.Administration;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}