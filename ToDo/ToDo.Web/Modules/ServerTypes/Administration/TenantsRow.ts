import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface TenantsRow {
    TenantId?: number;
    TenantName?: string;
}

export abstract class TenantsRow {
    static readonly idProperty = 'TenantId';
    static readonly nameProperty = 'TenantName';
    static readonly localTextPrefix = 'Administration.Tenants';
    static readonly lookupKey = 'Administration.Tenant';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TenantsRow>('Administration.Tenant') }
    static async getLookupAsync() { return getLookupAsync<TenantsRow>('Administration.Tenant') }

    static readonly deletePermission = 'Administration:Tenant';
    static readonly insertPermission = 'Administration:Tenant';
    static readonly readPermission = 'Administration:Tenant';
    static readonly updatePermission = 'Administration:Tenant';

    static readonly Fields = fieldsProxy<TenantsRow>();
}