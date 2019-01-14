using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Die
    {
        //Create an neww instance of the math class Random
        //This instance(Occurance, Object) will be shared by each instance of the class Die
        //This instance will be created when the first instnace of Die is created
        private static Random _rnd = new Random();

        //This is the definition of a object
        //It is a conceptual view of the data
        //That will be held by a physical instance (object) of this class

        //Data Members
        //is an internal private data storage item
        //Private data members cannot be reached directly by the user
        //Public data members can be reached directly by the users
        private int _Sides;
        private string _Color;
        //Properties
        //is an external interface between the users and a single piece of data within the instance
        //A property has two abilities
        //  a) The ability to assgin a value to the internal data member
        //  b) Return a internal data member value to the user

        //Fully Implemented Proverty
        public int Sides
        {
            get
            {
                //Takes internal value and returns it to the user
                return _Sides;
            }

            set
            {
                //Takes the supplied user value and places it into the internal private data member
                //The incoming piece of data is placed into a special variable that is called: value
                //Optionally you may place validation on the incoming value
                if (value >= 6 && value <= 20)
                {
                    _Sides = value;
                    Roll(); //Consider placing this method within the property if the set is public and not private
                            //If private then the method SetSides solves this problem
                }
                else
                {
                    throw new Exception("Die cannot be " + value.ToString() + " sides. Die must have between 6 and 20 sides.");
                }
            }
        }
        //Another version of Sides using a private set and auto implemented property
        //In this version you would need to code a method like SetSides()
        //public int Sides { get; private set; }



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

        //Optional: if not supplied the system, dafault constructor in used which will assign a system value to each data member/auto implemented property according to it's data type

        //You can have any number of constructors within your class
        //As soon as you code a constructor, your program is responsible for all constructors

        //Syntax  public classname([list of parameters]) { .... }

        //Typical Constructors
        //Default Constructor
        //This is similar to the system default constructor
        public Die()
        {
            //You could leave this constructor empty and the system would acess the normal dafault value to your data members and auto implemented properties

            //You can directly access a private data member in any place within your class
            _Sides = 6;

            //You can access any property any place with your class
            _Color = "White";

            //You could use a class method to generate a value for a data member/auto property
            Roll();
        }

        //Greedy Constructor
        //Typically has a parameter for each data member and auto implemented propert within your class
        //Parameter order is not important
        //This constructor allows the outside user to create and assign their own values to the data members/auto properties at the time of instance creation
        public Die(int sides, string color)
        {
            //since this data is coming from an outside source, it is best to use your property to save the values; specially if the property has validation
            Sides = sides;
            Color = color;
            Roll();
        }

        //Behaviours (methods)

        //These are actions that the class can perform
        //The actions may or may not alter data members/auto property values
        //The actions could simply take a value(s) from the user and perform some logic operations against the values
        
        //Can be public or private
        //Create a method that allows the user to change the number of sides on a die
        public void SetSides(int sides)
        {
            if (sides >= 6 && sides <= 20)
            {
                Sides = sides;
            }
            else
            {
                //optionally
                //a) Throw a new exception
                throw new Exception("Invalid value for sides");
                //b) Set _Sides to a default value
                //Sides = 6;
            }
            Roll();
        }

        public void Roll()
        {
            //No paramters are required for this method since it will be using the inernal data values to complete its functionality

            //Randomly generate a value for the die depending on the maximum sides
            FaceValue = _rnd.Next(1, Sides + 1);
        }
    }
}
