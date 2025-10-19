using Serenity.ComponentModel;
using System;
using ToDo.Modules.Administration.Person;

namespace ToDo.Administration.Forms;

[FormScript("Administration.Person")]
[BasedOnRow(typeof(PersonRow), CheckNames = true)]
public class PersonForm
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //[Tab("Movies"), IgnoreName, PersonMovieGrid, LabelWidth("0")]
    public string PrimaryImage { get; set; }
    public string GalleryImages { get; set; }
    public DateTime BirthDate { get; set; }
    public string BirthPlace { get; set; }
    public Gender Gender { get; set; }
    public int Height { get; set; }
}