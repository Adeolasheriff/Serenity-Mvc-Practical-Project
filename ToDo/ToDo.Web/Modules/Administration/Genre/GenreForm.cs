using Serenity.ComponentModel;

namespace ToDo.Administration.Forms;

[FormScript("Administration.Genre")]
[BasedOnRow(typeof(GenreRow), CheckNames = true)]
public class GenreForm
{
    public string Name { get; set; }
}