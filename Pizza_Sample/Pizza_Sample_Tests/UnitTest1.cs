
namespace Pizza_Sample_Tests;

public class Tests
{
    Validator validator;
    [SetUp]
    public void Setup()
    {
        validator = new Validator();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
