namespace TenisApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Marca = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Precio = c.Int(nullable: false),
                        Descuento = c.String(),
                        Imagen = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Talla",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Producto_Id = c.Int(nullable: false),
                        Tallas = c.String(nullable: false, maxLength: 50),
                        Color = c.String(nullable: false),
                        Tipo = c.String(nullable: false),
                        Sexo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Producto", t => t.Producto_Id, cascadeDelete: true)
                .Index(t => t.Producto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Talla", "Producto_Id", "dbo.Producto");
            DropIndex("dbo.Talla", new[] { "Producto_Id" });
            DropTable("dbo.Talla");
            DropTable("dbo.Producto");
        }
    }
}
