using Serenity.Navigation;
using MyPages = ToDo.MovieDB.Pages;

//[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie", typeof(MyPages.MoviePage), "fa-video-camera")]
[assembly: NavigationMenu(6000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(6100, "Movie Database/Movies",
    typeof(MyPages.MoviePage), icon: "fa-video-camera")]