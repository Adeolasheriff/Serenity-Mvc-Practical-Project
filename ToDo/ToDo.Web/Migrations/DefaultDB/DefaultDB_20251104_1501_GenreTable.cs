//using FluentMigrator;

//namespace MovieTutorial.Migrations.DefaultDB;

//[DefaultDB, MigrationKey(20251104_1501)]
//public class DefaultDB_20251104_1500_GenreTable : AutoReversingMigration
//{
//    public override void Up()
//    {
//        Create.Table("Genre")
//            .WithColumn("GenreId").AsInt32().NotNullable()
//                .PrimaryKey().Identity()
//            .WithColumn("Name").AsString(100).NotNullable();

     

//        Insert.IntoTable("Genre")
//            .Row(new { Name = "Action" })
//            .Row(new { Name = "Drama" })
//            .Row(new { Name = "Comedy" })
//            .Row(new { Name = "Sci-fi" })
//            .Row(new { Name = "Fantasy" })
//            .Row(new { Name = "Documentary" });
//    }


//}