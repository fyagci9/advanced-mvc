namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_messageclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessagesID = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(maxLength: 50),
                        ReceiverMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 50),
                        MessagesContent = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessagesID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
