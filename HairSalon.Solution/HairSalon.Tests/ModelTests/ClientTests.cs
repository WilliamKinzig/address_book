using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest
  {
    [TestClass]
    public void GetName_ReturnName_String()
    {
      string name = 'bob';
      Client newClient = new Client(name);

      string nameReturned = newClient.GetName();

      Assert.AreEqual(name, nameReturned);



    }
  }
}
