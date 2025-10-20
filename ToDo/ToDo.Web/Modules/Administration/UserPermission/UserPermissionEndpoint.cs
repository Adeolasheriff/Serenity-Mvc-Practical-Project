
using ToDo.Administration.Repositories;

namespace ToDo.Administration.Endpoints
{
    [Route("Services/Administration/UserPermission/[action]")]
    [ConnectionKey(typeof(UserPermissionRow)), ServiceAuthorize(typeof(UserPermissionRow))]
    public class UserPermissionEndpoint : ServiceEndpoint
    {
        [HttpPost, AuthorizeUpdate(typeof(UserPermissionRow))]
        public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request)
        {
            return new UserPermissionRepository(Context).Update(uow, request);
        }

        //[HttpPost, AuthorizeRead(typeof(UserPermissionRow))]
        public ListResponse<UserPermissionRow> List(IDbConnection connection, UserPermissionListRequest request)
        {
            return new UserPermissionRepository(Context).List(connection, request);
        }

        //[HttpPost, AuthorizeRead(typeof(UserPermissionRow))]
        public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request)
        {
            return new UserPermissionRepository(Context).ListRolePermissions(connection, request);
        }
        public ListResponse<string> ListPermissionKeys(
       [FromServices] IPermissionKeyLister permissionKeyLister)
        {
            return new ListResponse<string>
            {
                Entities = permissionKeyLister.ListPermissionKeys(includeRoles: false).ToList()
            };
        }

    }
}
