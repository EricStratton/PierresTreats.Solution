using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
    public Treat Treat { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}