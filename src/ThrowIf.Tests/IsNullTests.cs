using Xunit;
namespace Throw.Tests;

public class IsNullTests
{
    [Fact]
    public void WhenArgIsNotNull_DoesNotThrow()
    {
        ThrowIf.ThrowIf.IsNull(new object());
    }
}
