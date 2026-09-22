using System.ComponentModel.DataAnnotations;

namespace ShreyShop.Catalog.API.Model;

public class CatalogBrand
{
    public CatalogBrand(string brand) {
        Brand = brand;
    }

    public int Id { get; set; }

    [Required]
    public string Brand { get; set; }
}
