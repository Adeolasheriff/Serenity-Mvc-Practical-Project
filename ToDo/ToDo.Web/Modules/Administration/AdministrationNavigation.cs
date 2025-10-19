using DocumentFormat.OpenXml.Spreadsheet;
using Serenity.Navigation;
using Administration = ToDo.Administration.Pages;
using MyPages = ToDo.Administration.Pages;

[assembly: NavigationMenu(9000, "Administration", icon: "fa-wrench")]
[assembly: NavigationLink(9100, "Administration/Languages", typeof(Administration.LanguagePage), icon: "fa-comments")]
[assembly: NavigationLink(9200, "Administration/Translations", typeof(Administration.TranslationPage), icon: "fa-comment-o")]
[assembly: NavigationLink(9300, "Administration/Roles", typeof(Administration.RolePage), icon: "fa-lock")]
[assembly: NavigationLink(9400, "Administration/User Management", typeof(Administration.UserPage), icon: "fa-users")]
[assembly: NavigationLink(int.MaxValue, "Administration/Genre", typeof(MyPages.GenrePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Administration/Movie", typeof(MyPages.MoviePage), icon: "fa-video-camera")]
[assembly: NavigationLink(int.MaxValue, "Administration/Person", typeof(MyPages.PersonPage), icon: "fa - users")]
[assembly: NavigationLink(int.MaxValue, "Administration/Tenants", typeof(MyPages.TenantsPage), icon: null)]

