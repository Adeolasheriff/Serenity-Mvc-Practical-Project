using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace ToDo.Administration;

[ConnectionKey("Default"), Module("Administration"), TableName("Tenants")]
[DisplayName("Tenants"), InstanceName("Tenants")]
[ReadPermission(PermissionKeys.Tenants)]
[ModifyPermission(PermissionKeys.Tenants)]
[ServiceLookupPermission(PermissionKeys.Tenants)]
[LookupScript("Administration.Tenant")]
public sealed class TenantsRow : Row<TenantsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Tenant Id"), Identity, IdProperty]
    public int? TenantId { get => fields.TenantId[this]; set => fields.TenantId[this] = value; }

    [DisplayName("Tenant Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string TenantName { get => fields.TenantName[this]; set => fields.TenantName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field TenantId;
        public StringField TenantName;

    }
}