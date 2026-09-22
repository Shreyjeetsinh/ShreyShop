global using ShreyShop.ClientApp.Services;
global using ShreyShop.ClientApp.Services.AppEnvironment;
global using ShreyShop.ClientApp.Services.Basket;
global using ShreyShop.ClientApp.Services.Catalog;
global using ShreyShop.ClientApp.Services.Order;
global using ShreyShop.ClientApp.Services.Settings;
global using ShreyShop.ClientApp.ViewModels;
global using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
