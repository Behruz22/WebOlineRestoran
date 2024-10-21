using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
    public int OrderId { get; set; }
    [JsonIgnore]
    public virtual Order? Order { get; set; }
    public int FoodId { get; set; }
    [JsonIgnore]
    public virtual Food? Food { get; set; }
}
