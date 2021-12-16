namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CRUD_Cstmr",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        family = c.String(),
                        cstmrid = c.String(),
                        mobile = c.String(),
                        natnlid = c.String(),
                        phone = c.String(),
                        how = c.String(),
                        prdctname = c.String(),
                        cmpnyname = c.String(),
                        price = c.String(),
                        dscrptn = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CRUD_Cstmr");
        }
    }
}
