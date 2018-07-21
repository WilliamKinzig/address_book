namespace HairSalon.Models
{
  public class Client
  {
    private int id;
    private string _name;

    public Client(string nameIn)
    {
      // _name = nameIn;
    }

    public string GetClientName()
    {
      return _name;
    }

  }
}
