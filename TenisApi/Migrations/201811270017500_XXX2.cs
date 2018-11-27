namespace TenisApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XXX2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Talla", "Producto_Id", "dbo.Producto");
            DropIndex("dbo.Talla", new[] { "Producto_Id" });
            AddColumn("dbo.Talla", "Producto_Id1", c => c.Int());
            CreateIndex("dbo.Talla", "Producto_Id1");
            AddForeignKey("dbo.Talla", "Producto_Id1", "dbo.Producto", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Talla", "Producto_Id1", "dbo.Producto");
            DropIndex("dbo.Talla", new[] { "Producto_Id1" });
            DropColumn("dbo.Talla", "Producto_Id1");
            CreateIndex("dbo.Talla", "Producto_Id");
            AddForeignKey("dbo.Talla", "Producto_Id", "dbo.Producto", "Id", cascadeDelete: true);
        }
    }
}
