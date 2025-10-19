using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.Administration.PersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.Administration.PersonRow;

namespace ToDo.Administration;

public interface IPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonSaveHandler
{
    public PersonSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}