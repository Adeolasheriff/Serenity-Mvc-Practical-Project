//using FluentMigrator;

//namespace MovieTutorial.Migrations.DefaultDB;

//[DefaultDB, MigrationKey(20251105_1503)]
//public class DefaultDB_20251104_1503_MovieGenre: ForwardOnlyMigration
//{
//    public override void Up()
//    {
//        Create.Table("MovieGenres")
//            .WithColumn("MovieGenreId").AsInt32()
//                .Identity().PrimaryKey().NotNullable()
//            .WithColumn("MovieId").AsInt32().NotNullable()
//                .ForeignKey("FK_MovieGenres_MovieId", "Movie", "MovieId")
//            .WithColumn("GenreId").AsInt32().NotNullable()
//                .ForeignKey("FK_MovieGenres_GenreId", "Genre", "GenreId");
//        // copy data from movie where genreid isnt null
//        Execute.Sql(
//            @"INSERT INTO MovieGenres (MovieId, GenreId) 
//                SELECT m.MovieId, m.GenreId 
//                FROM Movie m 
//                WHERE m.GenreId IS NOT NULL");

//        Delete.ForeignKey("FK_Movie_GenreId")
//            .OnTable("Movie");
//        Delete.Column("GenreId")
//            .FromTable("Movie");
//    }


//    }