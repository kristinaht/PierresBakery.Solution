namespace PierresBakery
{
  public class TreatFlavor
  {
    public int TreatFlavorId { get; set; }
    public int ItemId { get; set; }
    public int CategoryId { get; set; }
    public Item Item { get; set; }
    public Category Category { get; set; }
  }
}