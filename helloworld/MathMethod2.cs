using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    public class MathMethod2
    {
        public int SomeCaculate(MathMethod.ENUM_OPR opr)
        {
            int res = 0;
            switch (opr)
            {
                case MathMethod.ENUM_OPR.ADD:
                    res = 1;
                    break;
                case MathMethod.ENUM_OPR.MINUS:
                    res = 2;
                    break;
                case MathMethod.ENUM_OPR.MULTIPLY:
                    res = 3;
                    break;
                case MathMethod.ENUM_OPR.DEVIDE:
                    res = 4;
                    break;
                default:
                    break;
            }

            if (res < 2)
            {
                return -1;
            }

            return 0;
        }
    }
}
