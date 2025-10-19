import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { MovieGenresRow } from "./MovieGenresRow";

export namespace MovieGenresService {
    export const baseUrl = 'Administration/MovieGenres';

    export declare function Create(request: SaveRequest<MovieGenresRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<MovieGenresRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MovieGenresRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<MovieGenresRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<MovieGenresRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<MovieGenresRow>>;

    export const Methods = {
        Create: "Administration/MovieGenres/Create",
        Update: "Administration/MovieGenres/Update",
        Delete: "Administration/MovieGenres/Delete",
        Retrieve: "Administration/MovieGenres/Retrieve",
        List: "Administration/MovieGenres/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>MovieGenresService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}