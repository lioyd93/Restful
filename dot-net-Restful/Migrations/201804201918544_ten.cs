namespace dot_net_Restful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ten : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MemberType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MemberType");
        }
    }
}
