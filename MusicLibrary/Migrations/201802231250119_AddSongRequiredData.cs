namespace MusicLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSongRequiredData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Songs", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Songs", "Author", c => c.String(nullable: false));
            AlterColumn("dbo.Songs", "Genre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Songs", "Genre", c => c.String());
            AlterColumn("dbo.Songs", "Author", c => c.String());
            AlterColumn("dbo.Songs", "Title", c => c.String());
        }
    }
}
