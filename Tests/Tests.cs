using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {

        
        // Write Unit Tests for all functions for your assigned group

        //Theory needs params for the test function
        [Theory]
        [InlineData(14,3,4)]
        [InlineData(18,4,5)]
        [InlineData(8,-2,-2)]
        [InlineData(20,-5,-5)]

        public void CalcRectPerimeter(int expected, int length, int width){
            //construct if need to
            var ml = new GroupTwoFunctions();
            var result = ml.CalcRectArea(length, width);
            Assert.Equal(result, expected);
        }


        [Theory]
        [InlineData(true,1)]
        [InlineData(true,10)]
        [InlineData(false,16)]
        [InlineData(true,91)]
        public void IsTriangularNum(Boolean expected,int num)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CalcRectArea(num);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(41,5)]
        [InlineData(10,50)]
        [InlineData(-21,-5)]
        [InlineData(-18,1)]
        public void FarenheitToCelcius(int expected,int farenheit)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CalcRectArea(farenheit);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(false,'A')]
        [InlineData(true,word(5))]
        [InlineData(false,word(10))]
        [InlineData(true,' ')]
        public void CheckWhiteSpace(Boolean expected,string word)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CalcRectArea(word);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("I aM tHe BeSt","i am the best")]
        [InlineData("WhO iS yOuR dAdDy", "WHO IS YOUR DADDY")]
        [InlineData("SuH sUh MaTe","sUh SuH mAtE")]
        public void CamelString(string expected,string word)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CalcRectArea(word);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1,"i am the best 3")]
        [InlineData(3, "1s u 4ty 4")]
        [InlineData(0,"I dont believe so")]
        public void CountDigits(int expected,string word)
        {
            var ml = new GroupTwoFunctions();
            var result = ml.CalcRectArea(word);
            Assert.Equal(result, expected);
        }
    }
}
