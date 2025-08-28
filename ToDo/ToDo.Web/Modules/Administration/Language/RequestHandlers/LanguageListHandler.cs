using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ToDo.Administration.LanguageRow>;
using MyRow = ToDo.Administration.LanguageRow;


namespace ToDo.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}