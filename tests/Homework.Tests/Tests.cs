using Xunit;

namespace Homework.Tests
{
    public class Tests
    {
        [Fact]
        public void TestGreeter()
        {
            var greeter = new Greeter();

            // TODO: Check that greeter works as expected.
            // You can learn more about xUnit here:
            // https://xunit.net/docs/getting-started/netfx/visual-studio#write-first-tests
        }

        // This second test uses the "Theory" attribute.
        // This lets us provide multiple test inputs.
        // See: https://xunit.net/docs/getting-started/netfx/visual-studio#write-first-theory
        [Theory]
        [InlineData(new[] { "Foo", "Bar" }, 2)]
        public void TestCounter(string[] names, int expectedResult)
        {
            var counter = new Counter();

            // TODO: Mock the IDatabase class.
            // See: https://github.com/moq/moq4/wiki/Quickstart

            // TODO: Check that the counter works as expected.
            // TODO: Add more inputs. What happens on identical strings? Strings with different casing?
        }
    }
}
