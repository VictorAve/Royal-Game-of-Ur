using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Game_of_Ur
{
    internal class Tile
    {
        private bool specialTile = false;
        private string belongsTo = " ";
        private bool isOccupied = false;

        public void setSpecial()
        {
            specialTile = true;
        }

        public bool getIsSpecial()
        {
            return specialTile;
        }

        public void setOccupied()
        {
            isOccupied = true;
        }

        public void setUnoccupied()
        {
            isOccupied = false;
        }

        public bool getisOccupied()
        {
            return isOccupied;
        }

        public void setOwner(int num)
        {
            if (num == 0)
            {
                belongsTo = " ";
            }
            else if (num == 1)
            {
                belongsTo = "1";
            }
            else if (num == 2)
            {
                belongsTo = "2";
            }
        }
        public string getOwner()
        {
            return belongsTo;
        }
    }
}
