using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebOnlineRestoran.Models;

public class Order
{
    public int Id { get; set; }
    public float TotalPrice { get; set; }
    public Status Status { get; set; } = Status.Accepted;
    public int UserId { get; set; }
    [JsonIgnore]
    public User? User { get; set; }  

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime OrderDate { get; set; } = DateTime.Now;
    [JsonIgnore]
    public virtual ICollection<OrderItem>? Items { get; set; }
}
