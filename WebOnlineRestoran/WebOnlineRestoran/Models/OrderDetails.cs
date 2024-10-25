using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class OrderDetails
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
    public int OrderId { get; set; }
    [JsonIgnore]
    public virtual Order? Order { get; set; }
    public int ProductId { get; set; }
    [JsonIgnore]
    public virtual Product? Product { get; set; }
}
