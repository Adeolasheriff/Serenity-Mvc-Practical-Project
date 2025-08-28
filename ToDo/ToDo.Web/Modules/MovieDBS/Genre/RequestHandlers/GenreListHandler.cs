using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ToDo.MovieDBS.GenreRow>;
using MyRow = ToDo.MovieDBS.GenreRow;

namespace ToDo.MovieDBS;

public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
{
    public GenreListHandler(IRequestContext context)
            : base(context)
    {
    }
}