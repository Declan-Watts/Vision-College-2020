using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyAgency2019.Business
{
    public static class Factory
    {

        public static Spy GetASpy(int ID)
        {
            switch (ID)
            {
                case 1:
                    return new Spy();
                case 2:
                    return new Double02();
                case 3:
                    return new Double03();
                case 4:
                    return new Double04();
                case 5:
                    return new Double05();
                case 6:
                    return new Double06();
                case 7:
                    return new Double07();
                default:
                    return new Spy();
            }
        }

    }
}
