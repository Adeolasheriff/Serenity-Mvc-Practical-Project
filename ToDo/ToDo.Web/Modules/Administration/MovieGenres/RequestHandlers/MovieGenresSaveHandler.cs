using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.Administration.MovieGenresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.Administration.MovieGenresRow;

namespace ToDo.Administration;

public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresSaveHandler
{
    public MovieGenresSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}