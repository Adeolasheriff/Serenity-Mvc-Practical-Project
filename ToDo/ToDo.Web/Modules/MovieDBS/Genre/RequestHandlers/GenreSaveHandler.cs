using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.MovieDBS.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.MovieDBS.GenreRow;

namespace ToDo.MovieDBS;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}