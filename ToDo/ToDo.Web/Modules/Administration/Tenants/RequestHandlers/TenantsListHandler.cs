using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ToDo.Administration.TenantsRow>;
using MyRow = ToDo.Administration.TenantsRow;

namespace ToDo.Administration;

public interface ITenantsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class TenantsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsListHandler
{
    public TenantsListHandler(IRequestContext context)
            : base(context)
    {
    }
}