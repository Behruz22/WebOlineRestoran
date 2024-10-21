using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class User 
{
    public int Id { get; set; }
    public string Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<Order>? Orders { get; set; }
}
