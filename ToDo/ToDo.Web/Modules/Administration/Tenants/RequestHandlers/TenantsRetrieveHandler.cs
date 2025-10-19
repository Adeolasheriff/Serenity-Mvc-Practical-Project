using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ToDo.Administration.TenantsRow>;
using MyRow = ToDo.Administration.TenantsRow;

namespace ToDo.Administration;

public interface ITenantsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class TenantsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsRetrieveHandler
{
    public TenantsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}