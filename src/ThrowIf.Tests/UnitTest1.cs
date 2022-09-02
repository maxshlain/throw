using Xunit;
namespace Throw.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        ThrowIf.ThrowIf.IsNull(new object());
    }
}
