﻿namespace Disabled.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "City", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "City");
        }
    }
}
