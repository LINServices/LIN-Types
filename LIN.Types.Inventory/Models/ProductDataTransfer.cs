using LIN.Types.Inventory.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Inventory.Models;


/// <summary>
/// Modelo de un Producto
/// </summary>
public class ProductDataTransfer
{

    public int ProductID { get; set; } = 0;

    public byte[] Image { get; set; } = Array.Empty<byte>();

    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public ProductCategories Category { get; set; } = ProductCategories.Undefined;

    public ProductBaseStatements Estado { get; set; }

    public int Provider { get; set; } = 0;

    public int Inventory { get; set; } = 0;

    public int Plantilla { get; set; } = 0;

    public int IDDetail { get; set; } = 0;

    public decimal PrecioCompra { get; set; } = 0m;

    public decimal PrecioVenta { get; set; } = 0m;

    public int Quantity { get; set; } = 0;

    public ProductStatements EstadoDetail { get; set; } = ProductStatements.Normal;



    public void Normalize()
    {
        Description = Description.Replace("\r", "\n");
    }


    public void FillWith(ProductDataTransfer model)
    {
        ProductID = model.ProductID;
        Image = model.Image;
        Name = model.Name;
        Code = model.Code;
        Description = model.Description;
        //  this.Category = model.Category;
        Description = model.Description;
        Estado = model.Estado;
        Provider = model.Provider;
        Inventory = model.Inventory;
    }






}
