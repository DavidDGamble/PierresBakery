namespace PierresBakery.Models
{
  public class Pastry
  {
    private int _pastryTotal;
    private int _totalCost { get; set; }

    public Pastry(int pastryTotal)
    {
      _pastryTotal = pastryTotal;
      _totalCost = 0;
    }

    public int GetPastryTotal() { return _pastryTotal; }
    public int GetTotalCost() { return _totalCost; }

    public void CalcTotal()
    {
      _totalCost = _pastryTotal * 2;
      if (_pastryTotal > 2)
      {
        int freeNum = _pastryTotal / 3;
        _totalCost -= freeNum;
      }
    }
  }
}