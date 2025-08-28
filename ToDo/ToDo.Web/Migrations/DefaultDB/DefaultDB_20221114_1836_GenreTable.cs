using FluentMigrator;

namespace ToDo.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20221114_1836)]
public class DefaultDB_20221114_1836_GenreTable:AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Genre")
             .WithColumn("GenreId").AsInt32().NotNullable()
                 .PrimaryKey().Identity()
             .WithColumn("Name").AsString(100).NotNullable();

        Alter.Table("Movie")
            .AddColumn("GenreId").AsInt32().Nullable()
                .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");
        //public int GenreId { get; set; }     // foreign key property
    //public Genre Genre { get; set; }     // navigation property


    Insert.IntoTable("Genre")
            .Row(new { Name = "Action" })
            .Row(new { Name = "Drama" })
            .Row(new { Name = "Comedy" })
            .Row(new { Name = "Sci-fi" })
            .Row(new { Name = "Fantasy" })
            .Row(new { Name = "Documentary" });
    }
}
