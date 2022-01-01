using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Game_of_Ur
{
    class Board
    {

        public Tile[] P1Row = new Tile[6];
        public Tile[] P2Row = new Tile[6];
        public Tile[] centerRow = new Tile[8];
        public Tile[][] boardState = new Tile[3][];
        public void initialise()
        {
            Tile thisTile;
            for (int i = 0; i < P1Row.Length; i++)
            {
                P1Row[i] = new Tile();
                thisTile = P1Row[i];
                if (i == 3)
                {
                    thisTile.setSpecial();
                }
                P1Row[i] = thisTile;
            }
            boardState[0] = P1Row;

            for (int i = 0; i < centerRow.Length; i++)
            {
                centerRow[i] = new Tile();
                thisTile = centerRow[i];
                if (i == 3)
                {
                    thisTile.setSpecial();
                }
                centerRow[i] = thisTile;
            }
            boardState[0] = centerRow;

            for (int i = 0; i < P2Row.Length; i++)
            {
                P2Row[i] = new Tile();
                thisTile = P2Row[i];
                if (i == 3)
                {
                    thisTile.setSpecial();
                }
                P2Row[i] = thisTile;
            }
            boardState[0] = P2Row;
        }

    }
}
