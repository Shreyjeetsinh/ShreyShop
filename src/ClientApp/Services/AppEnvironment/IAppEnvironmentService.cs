using ShreyShop.ClientApp.Services.Basket;
using ShreyShop.ClientApp.Services.Catalog;
using ShreyShop.ClientApp.Services.Identity;
using ShreyShop.ClientApp.Services.Order;

namespace ShreyShop.ClientApp.Services.AppEnvironment;

public interface IAppEnvironmentService
{
    IBasketService BasketService { get; }

    ICatalogService CatalogService { get; }

    IOrderService OrderService { get; }

    IIdentityService IdentityService { get; }

    void UpdateDependencies(bool useMockServices);
}
