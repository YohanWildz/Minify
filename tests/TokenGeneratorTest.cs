using System;
using Minify.Model;
using Xunit;

namespace Minify.Tests
{
    public class TokenGeneratorTest
    {
        [Fact]
        public void Genereruntoken()
        {
            TokenGenerator generator = new TokenGenerator();   
            //aaa
            string test = generator.Generate();
            //Assert
            Assert.IsType<String>(test);
        }
    }
}
