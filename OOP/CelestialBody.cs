using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

/*
    public              - anyone can use it
    protected           - Only itself & its derived classes
    internal            - classes in current assembly can access 
    protected  internal - current assembly or derived classes.
    private             - Only containing class.    
 */


    /// <summary>
    /// abstract classes can not be implemented, derived classes
    /// must implement its abstract methods\properties. These are also considered virtual methods
    /// </summary>
    public abstract class CelestialBody
    {
        /// <summary>
        /// private member declaration, this member can be accessed by derived classes: asteriod, planet, & star
        /// </summary>
        protected float _massKilograms;

        /// <summary>
        /// A property allows clients to access private data, you can modify 
        /// the private data to better serve as seen in this example. 
        /// We store in kilograms, but user sees tons. 
        /// </summary>
        /*  Some good reasons to use properties at all times:
            * You can control acces (readonly,writeonly, read/write)
            * You can validate values when setting a property (check for null etc)
            * You can do additional processing, such as lazy initialization
            * You can change the underlying implementation. For example, a property may be backed by a member variable now, but you can change it to be backed by a DB row without breaking any user code.
        */ 

        public float MassInTons
        {
            get
            {
                return _massKilograms / Constants.kilosPerTon;
            }
        }

        /// <summary>
        /// these properties cannot be overwritten by a derived class
        /// </summary>
        public float X { get; set;}  //lightway syntax for generating a property A.K.A 'Auto implemented properties', .net generates a anonymous private member for each
        public float Y {get;set;}
        public float Z {get;set;}
        
        /// <summary>
        /// abstract keyword allows derived classes to change its default value
        /// </summary>
        public abstract bool EmitsLight { get { return false; } }

        public abstract void TranslateAcrossUniverse();

        /// <summary>
        /// This is a nested class, if you don't plan 
        /// on using it anywhere else. You can just define it within
        /// the client class.
        /// Also useful for factory patterns...
        /// </summary>
        class Constants
        {
            public const float kilosPerTon = 907.185f;
        }
    }
}
