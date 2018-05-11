namespace MVC_CodeAlong_110518_Amer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moreValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false));
        }
    }
}
