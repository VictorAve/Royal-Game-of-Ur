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

            int oneRoll;
            int[] quantities = new int[5];
            for (int i = 0; i < 5; i++)
            {
                quantities[i] = 0;
            }
            for (int i = 0; i < 16000; i++)
            {
                oneRoll = myDice.rollAll()[4];
                quantities[oneRoll] = quantities[oneRoll]+1;
            }
            Console.WriteLine();
            Console.WriteLine("0: {0}/1000  {1}", quantities[0], quantities[0] / 1000.0);
            Console.WriteLine("1: {0}/4000  {1}", quantities[1], quantities[1] / 4000.0);
            Console.WriteLine("2: {0}/6000  {1}", quantities[2], quantities[2] / 6000.0);
            Console.WriteLine("3: {0}/4000  {1}", quantities[3], quantities[3] / 4000.0);
            Console.WriteLine("4: {0}/1000  {1}", quantities[4], quantities[4] / 1000.0);
            Console.WriteLine();


            while (true)
            {
                string[] availableActions = { "filler" };
                int[] diceResult = myDice.rollAll();
                Console.WriteLine("You got [{0}{1}{2}{3}] totalling {4}",
                    diceResult[0], diceResult[1], diceResult[2], diceResult[3], diceResult[4]);
                Console.WriteLine("The available actions are: {0}", availableActions);
                Console.WriteLine("What piece do you want to move?");
                string action = Console.ReadLine();
                if (isValidAction(action, availableActions))
                {
                    move(action);
                }
            }
        }

        bool isValidAction(string action, string[] availableActions)
        {
            if (availableActions.Contains(action))
            {
                return true;
            }
            return false;
        }
        void move(string action)
        {

        }

        void capture()
        {

        }
    }
}
