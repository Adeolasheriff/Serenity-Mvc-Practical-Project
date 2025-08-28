using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.MovieDB.MovieRow;

namespace ToDo.MovieDB;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}