//using FluentMigrator;

//namespace MovieTutorial.Migrations.DefaultDB;

//[DefaultDB, MigrationKey(20251104_1500)]
//public class DefaultDB_20251104_1500_MovieKind : AutoReversingMigration
//{
//    public override void Up()
//    {
//        Alter.Table("Movie")
//            .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
//    }
//}