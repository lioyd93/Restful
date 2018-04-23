namespace dot_net_Restful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movie", new[] { "genre_GenerId" });
            CreateIndex("dbo.Movie", "Genre_GenerId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movie", new[] { "Genre_GenerId" });
            CreateIndex("dbo.Movie", "genre_GenerId");
        }
    }
}
