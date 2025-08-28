using Serenity.ComponentModel;

namespace ToDo.MovieDBS.Forms;

[FormScript("MovieDBS.Genre")]
[BasedOnRow(typeof(GenreRow), CheckNames = true)]
public class GenreForm
{
    public string Name { get; set; }
}