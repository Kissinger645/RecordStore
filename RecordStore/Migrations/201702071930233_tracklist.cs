namespace RecordStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tracklist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "TrackList", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "TrackList");
        }
    }
}
