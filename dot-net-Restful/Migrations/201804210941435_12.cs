namespace dot_net_Restful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movie", "Genre_GenerId", "dbo.Genres");
            DropIndex("dbo.Movie", new[] { "Genre_GenerId" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movie");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        GenreId = c.Int(nullable: false),
                        RelaeseDate = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                        Genre_GenerId = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenerId = c.Int(nullable: false, identity: true),
                        Genertype = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenerId);
            
            CreateIndex("dbo.Movie", "Genre_GenerId");
            AddForeignKey("dbo.Movie", "Genre_GenerId", "dbo.Genres", "GenerId");
        }
    }
}
