using System;
using System.Collections.Generic;
using System.Text;

namespace helloworld
{
    public class MathMethod
    {
        public enum ENUM_OPR {
            NULL,
            ADD,
            MINUS,
            MULTIPLY,
            DEVIDE,
        }
        public int Opr(ENUM_OPR opr, int a, int b)
        {
            int res = 0;
            switch (opr)
            {
                case ENUM_OPR.ADD:
                    res = a + b;
                    break;
                case ENUM_OPR.MINUS:
                    res = a - b;
                    break;
                case ENUM_OPR.MULTIPLY:
                    res = a * b;
                    break;
                case ENUM_OPR.DEVIDE:
                    res = a / b;
                    break;
                default:
                    break;
            }
            return res;
        }
        public double Opr(ENUM_OPR opr, double a, double b)
        {
            double res = 0;
            switch (opr)
            {
                case ENUM_OPR.ADD:
                    res = a + b;
                    break;
                case ENUM_OPR.MINUS:
                    res = a - b;
                    break;
                case ENUM_OPR.MULTIPLY:
                    res = a * b;
                    break;
                case ENUM_OPR.DEVIDE:
                    res = a / b;
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
