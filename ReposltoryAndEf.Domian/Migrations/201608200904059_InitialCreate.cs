namespace ReposltoryAndEf.Domian.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sys_User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(),
                        ACCOUNT = c.String(),
                        PASSWORD = c.String(),
                        ISCANLOGIN = c.Boolean(nullable: false),
                        SHOWORDER1 = c.Int(),
                        SHOWORDER2 = c.Int(),
                        PINYIN1 = c.String(),
                        PINYIN2 = c.String(),
                        FACE_IMG = c.String(),
                        LEVELS = c.String(),
                        DPTID = c.String(),
                        CREATEPER = c.String(),
                        CREATEDATE = c.DateTime(),
                        UPDATEUSER = c.String(),
                        UPDATEDATE = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sys_User");
        }
    }
}
