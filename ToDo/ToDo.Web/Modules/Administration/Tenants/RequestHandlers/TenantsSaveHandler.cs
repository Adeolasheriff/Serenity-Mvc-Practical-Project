using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ToDo.Administration.TenantsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ToDo.Administration.TenantsRow;

namespace ToDo.Administration;

public interface ITenantsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class TenantsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantsSaveHandler
{
    public TenantsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}