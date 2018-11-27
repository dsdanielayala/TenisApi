namespace TenisApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XXX3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Talla", new[] { "Producto_Id1" });
            DropColumn("dbo.Talla", "Producto_Id");
            RenameColumn(table: "dbo.Talla", name: "Producto_Id1", newName: "Producto_Id");
            AlterColumn("dbo.Talla", "Producto_Id", c => c.Int());
            CreateIndex("dbo.Talla", "Producto_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Talla", new[] { "Producto_Id" });
            AlterColumn("dbo.Talla", "Producto_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Talla", name: "Producto_Id", newName: "Producto_Id1");
            AddColumn("dbo.Talla", "Producto_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Talla", "Producto_Id1");
        }
    }
}
