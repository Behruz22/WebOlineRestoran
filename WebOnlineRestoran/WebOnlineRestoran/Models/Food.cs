using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class Food 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    [JsonIgnore]
    public virtual Category? Category { get; set; }

    public int AdminId { get; set; }
    [JsonIgnore]
    public virtual Admin? Admin { get; set; }

    [JsonIgnore]
    public virtual ICollection<OrderItem>? OrdersItems { get; set; }
}
