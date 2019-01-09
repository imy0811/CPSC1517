using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Die
    {
        //This is the definition of a object
        //It is a conceptual view of the data
        //That will be held by a physical instance (object) of this class

        //Data Members
        //is an internal private data storage item
        //Private data members cannot be reached directly by the user
        //Public data members can be reached directly by the users
        private int _Size;

        //Properties
        //is an external interface between the users and a single piece of data within the instance
        //A property has two abilities
        //  a) The ability to assgin a value to the internal data member
        //  b) Return a internal data member value to the user

        //Fully Implemented Proverty
        public int Size
        {
            get
            {
                //Takes internal values and returns it to the user
                return _Size;
            }

            set
            {
                //Takes the supplied user value and places it into the internal private data member
                //The incoming piece of data is placed into a special variable that is called: value
                _Size = value;
            }
        }
        //Constructors

        //Behaviours (methods)
    }
}
