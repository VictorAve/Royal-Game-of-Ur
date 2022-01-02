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
            P1Row = initialiseRow(6);
            boardState[0] = P1Row;
            P2Row = initialiseRow(6);
            boardState[2] = P2Row;
            centerRow = initialiseRow(8);
            boardState[1] = centerRow;     
        }

        Tile[] initialiseRow(int size)
        {
            Tile thisTile;
            Tile[] playerRow = new Tile[size];
            for (int i = 0; i < playerRow.Length; i++)
            {
                playerRow[i] = new Tile();
                thisTile = P1Row[i];
                if (i == 3 || (playerRow.Length == 6 && i == 5))
                {
                    thisTile.setSpecial();
                }
                playerRow[i] = thisTile;
            }
            return playerRow;
            
        }

    }
}
