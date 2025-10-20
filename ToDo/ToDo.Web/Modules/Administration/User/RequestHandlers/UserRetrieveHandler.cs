using AppServices;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ToDo.Administration.UserRow>;
using MyRow = ToDo.Administration.UserRow;


namespace ToDo.Administration;
public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
{
    public UserRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            return;
        var tenantId = User.GetTenantId();
        if (tenantId != null)
            query.Where(new Criteria(MyRow.Fields.TenantId) == tenantId.Value);


        //query.Where(MyRow.Fields.TenantId == User.GetTenantId());
    }
}