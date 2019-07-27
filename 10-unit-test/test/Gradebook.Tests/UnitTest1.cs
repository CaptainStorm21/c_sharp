using System;
using Xunit;

namespace Gradebook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //act
            var x = 5;
            var y = 9;
            var error = 9;
            var expected = 45;

            //act
            var actual = x * y;

            //dotnet run 
             //will yield error
            // Assert.Equal(expected, error);
           //dotnet run 
             //will yield no error
            Assert.Equal(expected, actual);
        }
    }
}
