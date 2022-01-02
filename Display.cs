using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Game_of_Ur
{
    internal class Display
    {
        public void printBoard(Board myBoard)
        {
            Console.WriteLine("P1:[0000000]      Score:[       ]");
            Console.WriteLine("+---+---+---+---+       +---+---+");
            Console.WriteLine("| {3} | {2} | {1} | {0} |       | {5} | {4} |",
                getVisual(" ", myBoard.P1Row[0]), getVisual(" ", myBoard.P1Row[1]), getVisual(" ", myBoard.P1Row[2]), 
                getVisual("*", myBoard.P1Row[3]), getVisual(" ", myBoard.P1Row[4]), getVisual("*", myBoard.P1Row[5]));
            Console.WriteLine("+---+---+---+---+---+---+---+---+");
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", 
                getVisual(" ", myBoard.centerRow[0]), getVisual(" ", myBoard.centerRow[1]), getVisual(" ", myBoard.centerRow[2]), 
                getVisual("*", myBoard.centerRow[3]), getVisual(" ", myBoard.centerRow[4]), getVisual(" ", myBoard.centerRow[5]), 
                getVisual(" ", myBoard.centerRow[6]), getVisual(" ", myBoard.centerRow[7]));
            Console.WriteLine("+---+---+---+---+---+---+---+---+");
            Console.WriteLine("| {3} | {2} | {1} | {0} |       | {5} | {4} |",
                getVisual(" ", myBoard.P2Row[0]), getVisual(" ", myBoard.P2Row[1]), getVisual(" ", myBoard.P2Row[2]),
                getVisual("*", myBoard.P2Row[3]), getVisual(" ", myBoard.P2Row[4]), getVisual("*", myBoard.P2Row[5]));
            Console.WriteLine("+---+---+---+---+       +---+---+");
            Console.WriteLine("P2:[0000000]      Score:[       ]");
        }

        string getVisual(string baseSymbol, Tile myTile)
        {
            string newSymbol = myTile.getisOccupied() ? myTile.getOwner():baseSymbol;
            return newSymbol;
        }
    }
}
