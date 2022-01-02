using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Game_of_Ur
{
    internal class Stone
    {
        private int ownedBy;

        void setOwner(int player)
        {
            ownedBy = player;
        }

        int getOwner()
        {
            return ownedBy;
        }
    }
}
