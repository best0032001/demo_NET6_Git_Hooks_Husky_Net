namespace Demo.Models;

public class BestItsc
{
    public int Id { get; set; }
    private int _xBest;


    public int GetName(int vaBest)
    {
        _xBest = vaBest;
        return _xBest;
    }
}






