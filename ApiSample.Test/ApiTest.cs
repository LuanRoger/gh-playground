using Xunit;
using System;
using ApiSample;

namespace ApiSample.Test
{
    public class ApiTest
    {
        [Fact]
        public void ToCamelTest() 
        {
            Assert.Equal("HeLlO WoRlD", Consts.STRING_TEST.ToCamel());
        }
    }
}