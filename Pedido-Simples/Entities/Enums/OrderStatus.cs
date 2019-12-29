using System;
namespace Pedido_Simples.Entities
{
    public enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
