using MovieTutorial.MovieDB;
using Serenity.ComponentModel;
using System;
//using ToDo.Modules.Administration.Movie;

namespace ToDo.Administration.Forms;

[FormScript("Administration.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieForm
{
    public string Title { get; set; }
    public string Description { get; set; }
    
    [DisplayName("Cast"), MovieCastEditor, IgnoreName]
    public List<MovieCastRow> CastList { get; set; }
    public string Storyline { get; set; }
    public MovieKind Kind { get; set; }
    public List<int> GenreList { get; set; }
    public string PrimaryImage { get; set; }
    public string GalleryImages { get; set; }
    //[Tab("Movies"), IgnoreName]
    //public string MoviesGrid { get; set; }
    public int Year { get; set; }
    public DateTime ReleaseDate { get; set; }

    [TextAreaEditor(Rows = 3)]
    public int Runtime { get; set; }
}