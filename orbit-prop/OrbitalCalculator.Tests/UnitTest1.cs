using System;
using Xunit;
using OrbitalCalculator.Constants;

namespace OrbitalCalculator.Tests
{
    public class ConstantsCheck
    {
        [Fact]
        public void QOMS2T_TEST()
        {
            Assert.Equal(0.00000000188027916,OrbitalConstants.QOMS2T(),12);
        }
        [Fact]
        public void S_TEST()
        {
            Assert.Equal(1.01222928,OrbitalConstants.S(),6);
        }
        [Fact]
        public void CK2_TEST()
        {
            Assert.Equal(0.0005413080,OrbitalConstants.CK2(),8);
        }
        [Fact]
        public void CK4_TEST()
        {
            Assert.Equal(0.00000062098875,OrbitalConstants.CK4(),6);
        }
    }
}
