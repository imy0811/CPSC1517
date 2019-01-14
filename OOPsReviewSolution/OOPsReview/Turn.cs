using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Turn
    {
        private int _player1;
        private int _player2;

        public int Player1
        {
            get
            {
                return _player1;
            }

            set
            {
                _player1 = value;
            }
        }


        public int Player2 { get; set; }

        public Turn ()
        {

        }

        public Turn (int player1, int player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
        //Methods
        //Public string FindRollResults()
        //{
        //      return null;
        //}
    }
}
