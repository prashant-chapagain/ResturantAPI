using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantAPI.Models;

public class OrderMaster
{
    [Key]
    public long OrderMasterId { get; set; }

    [Column(TypeName = "nvarchar(30)")]
    public string OrderNumber { get; set; }
    public int CustomerId { get; set; }

    [Column(TypeName = "nvarchar(30)")]
    public string PaymentMethod { get; set; }
    public decimal GrandTotal { get; set; }
}
