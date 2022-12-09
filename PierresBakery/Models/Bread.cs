namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadTotal { get; set; }
    private int _totalCost { get; set; }

    public Bread(int breadTotal)
    {
      BreadTotal = breadTotal;
      _totalCost = 0;
    }

    public int GetBreadTotal() { return BreadTotal; }
    public int GetTotalCost() { return _totalCost; }

    public void CalcTotal()
    {
      _totalCost = BreadTotal * 5;
      if (BreadTotal > 2)
      {
        int freeNum = BreadTotal / 3;
        _totalCost -= freeNum * 5;
      }
    }
  }
}