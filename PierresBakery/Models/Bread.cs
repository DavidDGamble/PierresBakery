namespace PierresBakery.Models
{
  public class Bread
  {
    private int _breadTotal; 
    private int _totalCost { get; set; }

    public Bread(int breadTotal)
    {
      _breadTotal = breadTotal;
      _totalCost = 0;
    }

    public int GetBreadTotal() { return _breadTotal; }
    public int GetTotalCost() { return _totalCost; }

    public void CalcTotal()
    {
      _totalCost = _breadTotal * 5;
      if (_breadTotal > 2)
      {
        int freeNum = _breadTotal / 3;
        _totalCost -= freeNum * 5;
      }
    }
  }
}