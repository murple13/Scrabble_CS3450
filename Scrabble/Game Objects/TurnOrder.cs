using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Game_Objects
{
    /// <summary>
    /// Handles the order of turns in the game.
    /// </summary>
    class TurnOrder
    {
        private int turnOrderIndex;
        private List<Player> turnQueue = new List<Player>();

        public TurnOrder()
        {

        }

        /// <summary>
        /// Makes the next player the current player.
        /// </summary>
        public void moveToNextPlayer()
        {
            if (turnOrderIndex >= turnQueue.Count-1) { turnOrderIndex = 0; }
            else { turnOrderIndex++; }
        }

        /// <summary>
        /// Returns the index of the player whose turn it currently is.
        /// </summary>
        /// <returns></returns>
        public int getActivePlayer()
        {
            return turnOrderIndex;
        }

        /// <summary>
        /// Checks to see if the turn queue contains the specified player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool containsPlayer(Player player)
        {
            return turnQueue.Contains(player);
        }

        /// <summary>
        /// Checks to see if there are any players in the turn queue.
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return turnQueue.Count == 0;
        }
    }
}
