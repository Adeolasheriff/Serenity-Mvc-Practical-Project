using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = ToDo.Administration.TenantsRow;

namespace ToDo.Administration;

public interface ITenantsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class TenantsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsDeleteHandler
{
    public TenantsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}