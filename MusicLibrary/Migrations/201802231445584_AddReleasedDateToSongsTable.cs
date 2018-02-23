namespace MusicLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleasedDateToSongsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "ReleasedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "ReleasedDate");
        }
    }
}
