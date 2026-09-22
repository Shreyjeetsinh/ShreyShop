using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ShreyShop.ClientApp.Messages;

public class ProductCountChangedMessage(int count) : ValueChangedMessage<int>(count);
