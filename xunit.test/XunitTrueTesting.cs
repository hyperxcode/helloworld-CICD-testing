using helloworld;
using System;
using System.Reflection;
using Xunit;

namespace helloworldxunit.test
{
    public class XunitTrueTesting
    {
        [Fact]
        public void TrueAndTrue()
        {
            Assert.True(true, "It is true");
        }

        [Fact]
        public void TrueButFalse()
        {
            //Assert.True(false, "It was false");
        }


        [Fact]
        public void MathMethodInt()
        {
            MathMethod mathMethod = new MathMethod();
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.NULL, 1, 2) == 0, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.ADD, 1, 2) == 3, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.MINUS, 4, 2) == 2, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.MULTIPLY, 4, 2) == 8, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.DEVIDE, 2, 2) == 1, "It is true");
        }

        [Fact]
        public void MathMethodDouble()
        {
            MathMethod mathMethod = new MathMethod();
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.NULL, 1.0, 2.0) == 0, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.ADD, 1.0, 2.0) == 3.0, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.MINUS, 4.0, 2.0) == 2.0, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.MULTIPLY, 4.0, 2.0) == 8.0, "It is true");
            Assert.True(mathMethod.Opr(MathMethod.ENUM_OPR.DEVIDE, 2.0, 2.0) == 1.0, "It is true");
        }

        [Fact]
        public void MathMethod2()
        {
            MathMethod2 mathMethod = new MathMethod2();
            Assert.True(mathMethod.SomeCaculate(MathMethod.ENUM_OPR.MINUS) == 2, "It is true");

        }
    }
}
