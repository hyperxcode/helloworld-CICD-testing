using helloworld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace helloworldmstest.test
{
    [TestClass]
    public class MstestTrueTesting
    {
        [TestMethod]
        public void MathMethodInt()
        {
            MathMethod mathMethod = new MathMethod();
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.NULL, 1, 2) == 0, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.ADD, 1, 2) == 3, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.MINUS, 4, 2) == 2, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.MULTIPLY, 4, 2) == 8, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.DEVIDE, 2, 2) == 1, "It is true");
        }

        [TestMethod]
        public void MathMethodDouble()
        {
            MathMethod mathMethod = new MathMethod();
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.NULL, 1.0, 2.0) == 0, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.ADD, 1.0, 2.0) == 3.0, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.MINUS, 4.0, 2.0) == 2.0, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.MULTIPLY, 4.0, 2.0) == 8.0, "It is true");
            Assert.IsTrue(mathMethod.Opr(MathMethod.ENUM_OPR.DEVIDE, 2.0, 2.0) == 1.0, "It is true");
        }

        [TestMethod]
        public void MathMethod2()
        {
            MathMethod2 mathMethod = new MathMethod2();
            Assert.IsTrue(mathMethod.SomeCaculate(MathMethod.ENUM_OPR.MINUS) == 2, "It is true");
            
        }
    }
}
