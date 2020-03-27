using System.Collections.Generic;

namespace PierresBakery
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string Description { get; set; }
    
    public ICollection<TreatFlavor> Treats { get; }
  }
}