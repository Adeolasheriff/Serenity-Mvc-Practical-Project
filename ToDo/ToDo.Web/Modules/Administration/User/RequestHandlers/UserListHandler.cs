using AppServices;
using static ToDo.ESM.Modules.Administration;
using MyRequest = ToDo.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<ToDo.Administration.UserRow>;
using MyRow = ToDo.Administration.UserRow;

namespace ToDo.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        if (Permissions.HasPermission(PermissionKeys.Tenants))
            return;

        //query.Where(MyRow.Fields.TenantId == User.GetTenantId());
        var tenantId = User.GetTenantId();
        if (tenantId != null)
            query.Where(new Criteria(MyRow.Fields.TenantId) == tenantId.Value);

    }
}
