import { fieldsProxy } from "@serenity-is/corelib";
import { MovieCastRow } from "./MovieCastRow";
import { MovieKind } from "./MovieKind";

export interface MovieRow {
    MovieId?: number;
    Title?: string;
    Description?: string;
    Storyline?: string;
    Year?: number;
    ReleaseDate?: string;
    PrimaryImage?: string;
    GalleryImages?: string;
    GenreList?: number[];
    TenantId?: number;
    CastList?: MovieCastRow[];
    Kind?: MovieKind;
    Runtime?: number;
}

export abstract class MovieRow {
    static readonly idProperty = 'MovieId';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Administration.Movie';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MovieRow>();
}