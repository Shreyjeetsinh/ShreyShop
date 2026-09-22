using System.Text.Json.Serialization;
using ShreyShop.ClientApp.Models.Catalog;
using ShreyShop.ClientApp.Models.Orders;
using ShreyShop.ClientApp.Models.Token;

namespace ShreyShop.ClientApp.Services;

[JsonSourceGenerationOptions(
    PropertyNameCaseInsensitive = true,
    NumberHandling = JsonNumberHandling.AllowReadingFromString)]
[JsonSerializable(typeof(CancelOrderCommand))]
[JsonSerializable(typeof(CatalogBrand))]
[JsonSerializable(typeof(CatalogItem))]
[JsonSerializable(typeof(CatalogRoot))]
[JsonSerializable(typeof(CatalogType))]
[JsonSerializable(typeof(Models.Orders.Order))]
[JsonSerializable(typeof(Models.Location.Location))]
[JsonSerializable(typeof(UserToken))]
internal partial class ShreyShopJsonSerializerContext : JsonSerializerContext
{
}
