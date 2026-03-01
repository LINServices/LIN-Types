namespace LIN.Types.Developer.BillingModels;

public class SubscriptionModel
{
    public int Id { get; set; }
    public SubscriptionType Type { get; set; }
    public BillingUnit? BillingUnit { get; set; }
    public decimal? Rate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    public int BillingAccountId { get; set; }
    public List<BillingPeriod> Periods { get; set; } = [];
}

public enum BillingUnit
{
    Hour,
    Day,
    Month
}

public enum SubscriptionType
{
    Fixed,
    Dynamic
}

public class InvoiceModel
{
    public int Id { get; set; }

    public SubscriptionModel? Subscription { get; set; }
    public int? SubscriptionId { get; set; }

    /// <summary>
    /// Fecha en la que la factura pasara de Buildind a pendingToPay, 
    /// es decir, la fecha en la que se intentara cobrar al cliente.
    /// </summary>
    public DateTime RecollectTime { get; set; }

    public List<InvoiceItem> Items { get; set; } = [];

    public InvoiceStatus Status { get; set; }
}

public enum InvoiceStatus
{
    Paid,
    Building,
    PendingToPay,
    Overdue
}

public class InvoiceItem
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;

    public int InvoiceId { get; set; }
    public InvoiceModel Invoice { get; set; } = new();
}


public class BillingPeriod
{
    public int Id { get; set; }
    public int SubscriptionId { get; set; }
    public SubscriptionModel Subscription { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}