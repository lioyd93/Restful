namespace dot_net_Restful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tenforec : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Membershiptypes", "MemberType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Membershiptypes", "MemberType", c => c.String());
        }
    }
}
