namespace ShreyShop.Ordering.API.Application.Commands;
using ShreyShop.Ordering.API.Application.Models;

public record CreateOrderDraftCommand(string BuyerId, IEnumerable<BasketItem> Items) : IRequest<OrderDraftDTO>;
