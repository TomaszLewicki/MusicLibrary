namespace MusicLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSongsTableReleaseDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Songs", "ReleasedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "ReleasedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Songs", "ReleaseDate");
        }
    }
}
