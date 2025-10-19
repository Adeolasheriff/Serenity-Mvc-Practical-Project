using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.Administration.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.Administration.GenreRow;

namespace ToDo.Administration;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}