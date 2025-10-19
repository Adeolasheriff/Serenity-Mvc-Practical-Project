import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PersonColumns, PersonRow, PersonService } from '../../ServerTypes/Administration';
import { PersonDialog } from './PersonDialog';

@Decorators.registerClass('ToDo.Administration.PersonGrid')
export class PersonGrid extends EntityGrid<PersonRow> {
    protected getColumnsKey() { return PersonColumns.columnsKey; }
    protected getDialogType() { return PersonDialog; }
    protected getRowDefinition() { return PersonRow; }
    protected getService() { return PersonService.baseUrl; }
}