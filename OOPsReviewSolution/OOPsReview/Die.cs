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
        private string _Color;
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
                //Takes internal value and returns it to the user
                return _Size;
            }

            set
            {
                //Takes the supplied user value and places it into the internal private data member
                //The incoming piece of data is placed into a special variable that is called: value
                //Optionally you may place validation on the incoming value
                if (value >= 6 && value <= 20)
                {
                    _Size = value;
                }
                else
                {
                    throw new Exception("Die cannot be " + value.ToString() + " sides. Die must have between 6 and 20 sides.");
                }                
            }
        }
        //Auto Implemented Property
        //  Public
        //  It has a datatype
        //  It has a name
        //  It DOES NOT have an internal data member that you can directly access
        //  The system will create, internally, a data storage area of the apropriate datatype and manage the area
        //  The only way to access the data of an Auto Implemented Property is via the property
        //  Usually use when there is no need for any internal validation or other proprty logic
        public int FaceValue { get; set; }

        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                // (value == null) this will fail for an empty string
                // (value ==)This will fail for a null value
                //
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Color has no value.");
                }
                else
                {
                    _Color = value;
                }
            }
        }


        //Constructors

        //Behaviours (methods)
    }
}
