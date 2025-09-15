using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var car = new Veiculo();
        car.Id = 1;
        car.Nome = "Corsa";
        car.Marca = "Chevrolet";
        car.Ano = 2010;

        Assert.AreEqual(1, car.Id);
        Assert.AreEqual("Corsa", car.Nome);
        Assert.AreEqual("Chevrolet", car.Marca);
        Assert.AreEqual(2010, car.Ano);
    }
}
