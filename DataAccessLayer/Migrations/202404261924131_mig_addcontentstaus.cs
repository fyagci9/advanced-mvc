﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addcontentstaus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "ContentStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contents", "ContentStatus");
        }
    }
}