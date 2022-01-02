/*
 * Royal Game of Ur
 * Victor Ferreira van Eyk
 * 30/12/2021
 * 
 * This is an ascii form of the Royal Game of Ur
 * This is my first foray into C#
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Game_of_Ur
{
    public class RoyalGameOfUr
    {
        static void Main(string[] args)
        {
            RoyalGameOfUr myGame = new RoyalGameOfUr();
            myGame.play();
        }

        void play()
        {
            Dice myDice = new Dice();
            Stone[] playerOneStones = new Stone[7];
            Stone[] playerTwoStones = new Stone[7];
            Board myBoard = new Board();
            myBoard.initialise();
            Display canvas = new Display();

            canvas.printBoard(myBoard);
        }

        void move()
        {

        }

        void capture()
        {

        }
    }
}
