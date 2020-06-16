using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassMovingMonsters.Business
{
    class Factory
    {
        //Decides which punter to instatiate 0,1,2

        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Howard();
                case 1:
                    return new Jack();
                case 2:
                    return new Vaughn();
                default:
                    return null;
            }
        }

    }
}
