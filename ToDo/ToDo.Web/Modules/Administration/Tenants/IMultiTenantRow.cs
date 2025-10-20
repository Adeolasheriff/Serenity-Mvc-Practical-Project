namespace ToDo;

public interface IMultiTenantRow
{
    Int32Field TenantIdField { get; }
}
