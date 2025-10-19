import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TenantsColumns, TenantsRow, TenantsService } from '../../ServerTypes/Administration';
import { TenantsDialog } from './TenantsDialog';

@Decorators.registerClass('ToDo.Administration.TenantsGrid')
export class TenantsGrid extends EntityGrid<TenantsRow> {
    protected getColumnsKey() { return TenantsColumns.columnsKey; }
    protected getDialogType() { return TenantsDialog; }
    protected getRowDefinition() { return TenantsRow; }
    protected getService() { return TenantsService.baseUrl; }
}