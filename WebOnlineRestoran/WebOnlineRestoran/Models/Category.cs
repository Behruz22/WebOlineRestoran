using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 
    [JsonIgnore]
    public virtual ICollection<Product>? Products { get; set; }
    public int AdminId { get; set; }
    [JsonIgnore]
    public virtual Admin? Admin { get; set; }
}
