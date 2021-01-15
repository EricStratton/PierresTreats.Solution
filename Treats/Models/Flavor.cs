using System.Collections.Generic;

namespace Treats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<TreatFlavor> Treats { get; set; }
  }
}