namespace Repography.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initProjectWithEF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FEATURES",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 255),
                        Routing = c.String(nullable: false, maxLength: 100),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PERMISSION_FEATURES",
                c => new
                    {
                        FeatureId = c.Guid(nullable: false),
                        PermissionId = c.Guid(nullable: false),
                        ActionType = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => new { t.FeatureId, t.PermissionId })
                .ForeignKey("dbo.FEATURES", t => t.FeatureId, cascadeDelete: true)
                .ForeignKey("dbo.PERMISSIONS", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.FeatureId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.PERMISSIONS",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 255),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.USER_PERMISSIONS",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        PermissionId = c.Guid(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => new { t.UserId, t.PermissionId })
                .ForeignKey("dbo.PERMISSIONS", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.USERS", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PERMISSION_FEATURES", "PermissionId", "dbo.PERMISSIONS");
            DropForeignKey("dbo.USER_PERMISSIONS", "UserId", "dbo.USERS");
            DropForeignKey("dbo.USER_PERMISSIONS", "PermissionId", "dbo.PERMISSIONS");
            DropForeignKey("dbo.PERMISSION_FEATURES", "FeatureId", "dbo.FEATURES");
            DropIndex("dbo.USER_PERMISSIONS", new[] { "PermissionId" });
            DropIndex("dbo.USER_PERMISSIONS", new[] { "UserId" });
            DropIndex("dbo.PERMISSION_FEATURES", new[] { "PermissionId" });
            DropIndex("dbo.PERMISSION_FEATURES", new[] { "FeatureId" });
            DropTable("dbo.USERS");
            DropTable("dbo.USER_PERMISSIONS");
            DropTable("dbo.PERMISSIONS");
            DropTable("dbo.PERMISSION_FEATURES");
            DropTable("dbo.FEATURES");
        }
    }
}
