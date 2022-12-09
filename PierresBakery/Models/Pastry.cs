namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryTotal { get; set; }
    private int _totalCost { get; set; }

    public Pastry(int pastryTotal)
    {
      PastryTotal = pastryTotal;
      _totalCost = 0;
    }

    public int GetPastryTotal() { return PastryTotal; }
    public int GetTotalCost() { return 500; }
  }
}