namespace TestCartuchera;
using Entidades;
using System.Runtime.Intrinsics.X86;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_CartucheraAgregarUtil()
    {
        //Arrange
        Cartuchera<Utiles> c1 = new Cartuchera<Utiles>();
        Lapiz l1=new Lapiz(1,10,"xx",ConsoleColor.Black);
        Lapiz l2 = new Lapiz(2, 10, "xx", ConsoleColor.Black);
        Lapiz l3 = new Lapiz(3, 10, "xx", ConsoleColor.Black);
        Goma g1 = new Goma(3, 10, "xx", Tipos.Simple);
        string aux;
        //Act
        aux = c1 + l1;
        aux = c1 + l2;
        aux = c1 + l3;
        aux = c1 + g1;
        //Assert
        Assert.IsTrue(c1.ListaUtiles.Count == 4);
    }
    [TestMethod]
    [ExpectedException(typeof(SinCoincidenciasException))]
    public void Test_BuscarUtilPorID()
    {
        //Arrange
        Cartuchera<Utiles> c1 = new Cartuchera<Utiles>();
        Lapiz l1 = new Lapiz(1, 10, "xx", ConsoleColor.Black);
        Lapiz l2 = new Lapiz(2, 10, "xx", ConsoleColor.Black);
        string aux;
        //Act
        aux = c1 + l1;
        aux = c1 + l2;
        c1.BuscarUtilPorId(3);
    }

}