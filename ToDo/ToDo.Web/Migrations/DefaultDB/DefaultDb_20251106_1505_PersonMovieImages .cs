using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20251106_1505)]
public class DefaultDB_20251106_1505_PersonMovieImages : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Person")
            .AddColumn("PrimaryImage").AsString(100).Nullable()
            .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

        Alter.Table("Movie")
            .AddColumn("PrimaryImage").AsString(100).Nullable()
            .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
    }
}