using ShreyShop.WebAppComponents.Catalog;

namespace ShreyShop.WebAppComponents.Item;

public static class ItemHelper
{
    public static string Url(CatalogItem item)
        => $"item/{item.Id}";
}
