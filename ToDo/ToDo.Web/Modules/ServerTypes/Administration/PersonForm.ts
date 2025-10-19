import { StringEditor, ImageUploadEditor, MultipleImageUploadEditor, DateEditor, EnumEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { Gender } from "../Modules/Administration.Person.Gender";

export interface PersonForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    PrimaryImage: ImageUploadEditor;
    GalleryImages: MultipleImageUploadEditor;
    BirthDate: DateEditor;
    BirthPlace: StringEditor;
    Gender: EnumEditor;
    Height: IntegerEditor;
}

export class PersonForm extends PrefixedContext {
    static readonly formKey = 'Administration.Person';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PersonForm.init)  {
            PersonForm.init = true;

            var w0 = StringEditor;
            var w1 = ImageUploadEditor;
            var w2 = MultipleImageUploadEditor;
            var w3 = DateEditor;
            var w4 = EnumEditor;
            var w5 = IntegerEditor;

            initFormType(PersonForm, [
                'FirstName', w0,
                'LastName', w0,
                'PrimaryImage', w1,
                'GalleryImages', w2,
                'BirthDate', w3,
                'BirthPlace', w0,
                'Gender', w4,
                'Height', w5
            ]);
        }
    }
}

[Gender]; // referenced types