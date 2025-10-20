import { StringEditor, EnumEditor, LookupEditor, ImageUploadEditor, MultipleImageUploadEditor, IntegerEditor, DateEditor, TextAreaEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { MovieCastEditor } from "../../Administration/MovieCast/MovieCastEditor";
import { MovieKind } from "./MovieKind";

export interface MovieForm {
    Title: StringEditor;
    Description: StringEditor;
    CastList: MovieCastEditor;
    Storyline: StringEditor;
    Kind: EnumEditor;
    GenreList: LookupEditor;
    PrimaryImage: ImageUploadEditor;
    GalleryImages: MultipleImageUploadEditor;
    Year: IntegerEditor;
    ReleaseDate: DateEditor;
    Runtime: TextAreaEditor;
}

export class MovieForm extends PrefixedContext {
    static readonly formKey = 'Administration.Movie';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieForm.init)  {
            MovieForm.init = true;

            var w0 = StringEditor;
            var w1 = MovieCastEditor;
            var w2 = EnumEditor;
            var w3 = LookupEditor;
            var w4 = ImageUploadEditor;
            var w5 = MultipleImageUploadEditor;
            var w6 = IntegerEditor;
            var w7 = DateEditor;
            var w8 = TextAreaEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Description', w0,
                'CastList', w1,
                'Storyline', w0,
                'Kind', w2,
                'GenreList', w3,
                'PrimaryImage', w4,
                'GalleryImages', w5,
                'Year', w6,
                'ReleaseDate', w7,
                'Runtime', w8
            ]);
        }
    }
}

[MovieKind]; // referenced types