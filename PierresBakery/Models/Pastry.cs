namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryTotal;
    private int _totalCost { get; set; }

    public Pastry(int pastryTotal)
    {
      PastryTotal = pastryTotal;
      _totalCost = 0;
    }

    public int GetPastryTotal() { return PastryTotal; }
    public int GetTotalCost() { return _totalCost; }

    public void CalcTotal()
    {
      _totalCost = PastryTotal * 2;
      if (PastryTotal > 2)
      {
        int freeNum = PastryTotal / 3;
        _totalCost -= freeNum;
      }
    }
  }
}