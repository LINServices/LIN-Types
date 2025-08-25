using LIN.Types.Payments.Enums;
using System;

namespace LIN.Types.Payments.Models;

public class OrderResponseModel
{
    public int Id { get; set; }
    public long OrderId { get; set; }
    public string Reference { get; set; }
    public OrderStatusEnum Status { get; set; }
    public DateTime Creation { get; set; }
    public DateTime Expiration { get; set; }
}