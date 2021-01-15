namespace Treats.Models
{
  public class Order
  {
    public int OrderId { get; set; }
    public int TreatId { get; set; }
    public int OrderSize { get; set; }
    
    [DisplayName("Order Date")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-mm-dd")]
    public DateTime OrderDate { get; set; }
  }
}