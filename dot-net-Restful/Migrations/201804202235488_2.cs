namespace dot_net_Restful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customer");
            RenameTable(name: "dbo.Movies", newName: "Movie");
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenerId = c.Int(nullable: false, identity: true),
                        Genertype = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenerId);
            
            AddColumn("dbo.Movie", "genreId", c => c.Int(nullable: false));
            AddColumn("dbo.Movie", "RelaeseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Movie", "genre_GenerId", c => c.Int());
            AlterColumn("dbo.Customer", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movie", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Movie", "genre_GenerId");
            AddForeignKey("dbo.Movie", "genre_GenerId", "dbo.Genres", "GenerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "genre_GenerId", "dbo.Genres");
            DropIndex("dbo.Movie", new[] { "genre_GenerId" });
            AlterColumn("dbo.Movie", "Name", c => c.String());
            AlterColumn("dbo.Customer", "Name", c => c.String());
            DropColumn("dbo.Movie", "genre_GenerId");
            DropColumn("dbo.Movie", "NumberInStock");
            DropColumn("dbo.Movie", "RelaeseDate");
            DropColumn("dbo.Movie", "genreId");
            DropTable("dbo.Genres");
            RenameTable(name: "dbo.Movie", newName: "Movies");
            RenameTable(name: "dbo.Customer", newName: "Customers");
        }
    }
}
