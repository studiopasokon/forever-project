using FluentAssertions;
using Xunit;

namespace StudioPasokon.ForeverProject.FuncProg.Tests
{
    /// <summary>
    /// This test class checks whether <see cref="Disposable.Using"/> can be used within functional programming.
    /// It also serves as an example on how to use the class and function.
    /// </summary>
    public class UsingTests
    {
        [Fact]
        public void DisposableObject_Disposes_properly()
        {
            // Arrange.
            const int inputValue = 10;

            // Act.
            var result = Disposable.Using(() => new ObjectUnderTest(), underTest => underTest.GetResult(inputValue));

            // Assert.
            result.Should().Be(inputValue);
            ObjectUnderTest.s_objectConstructed.Should().BeTrue();
            ObjectUnderTest.s_managedObjectsDisposed.Should().BeTrue();
            ObjectUnderTest.s_unmanagedObjectsDisposed.Should().BeTrue();
        }
    }
}
