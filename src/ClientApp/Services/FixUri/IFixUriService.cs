using ShreyShop.ClientApp.Models.Basket;
using ShreyShop.ClientApp.Models.Catalog;
using ShreyShop.ClientApp.Models.Marketing;

namespace ShreyShop.ClientApp.Services.FixUri;

public interface IFixUriService
{
    void FixCatalogItemPictureUri(IEnumerable<CatalogItem> catalogItems);
    void FixBasketItemPictureUri(IEnumerable<BasketItem> basketItems);
    void FixCampaignItemPictureUri(IEnumerable<CampaignItem> campaignItems);
}
