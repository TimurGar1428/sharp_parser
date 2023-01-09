using System.Reflection.Metadata;
using sharp_parser;
namespace sharp_parser_test;

public class Tests
{
    
    [SetUp]
    public void Setup()
    {
        User actual = new User { id = 1, name = "Tim" };
        User expected = new User { id = 2, name = "Tom" };
    }

    [Test]
    public void Test1()
    {
        User myUser = new User();
        Assert.Positive(myUser.id);
        //Assert.Positive(myUser.name);
        Assert.AreEqual(User.name, object actual.name);
        Assert.Pass();
    }
}