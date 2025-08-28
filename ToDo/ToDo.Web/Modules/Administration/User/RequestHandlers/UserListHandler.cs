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
}