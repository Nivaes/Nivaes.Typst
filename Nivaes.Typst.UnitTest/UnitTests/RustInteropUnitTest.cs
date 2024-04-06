namespace Nivaes.Typst.UnitTest.UnitTests
{
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using Xunit;

    public class RustInteropUnitTest
    {
        [Fact]
        public void RustInteropTest1()
        {
            int i = RustInterop.AddNumbers(2, 3);
            i.Should().Be(5);

        }
    }
}
