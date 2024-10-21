using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class Payment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    [JsonIgnore]
    public User User { get; set; }
    public int OrderId  { get; set; }
    [JsonIgnore]
    public Order Order { get; set; }
    public PaymentType PaymentType { get; set; } =PaymentType.cash;
}
