using System.Diagnostics.Contracts;
using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class Admin 
{
    public int Id { get; set; }
    public string Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<Category>? Categories { get; set; }

    [JsonIgnore]
    public virtual ICollection<Product>? Products { get; set; }

}
