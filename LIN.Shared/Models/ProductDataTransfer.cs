using LIN.Shared.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models;


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
        this.ProductID = model.ProductID;
        this.Image = model.Image;
        this.Name = model.Name;
        this.Code = model.Code;
        this.Description = model.Description;
        this.Category = model.Category;
        this.Description = model.Description;
        this.Category = model.Category;
        this.Estado = model.Estado;
        this.Provider = model.Provider;
        this.Inventory = model.Inventory;
    }






}
