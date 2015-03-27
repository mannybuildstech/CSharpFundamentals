using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        /*
         *                                                                  Classes vs Structs
         *           
         * In short: classes (by reference\pointers) structs (by value)
         * 
         * A class is a reference type. When an object of the class is created, the variable to which the object is assigned holds only a reference to that memory. 
         * When the object reference is assigned to a new variable, the new variable refers to the original object. Changes made through one variable are reflected 
         * in the other variable because they both refer to the same data.
           A struct is a value type. When a struct is created, the variable to which the struct is assigned holds the struct's actual data. When the struct is assigned 
         * to a new variable, it is copied. The new variable and the original variable therefore contain two separate copies of the same data. Changes made to one copy 
         * do not affect the other copy.
           In general, classes are used to model more complex behavior, or data that is intended to be modified after a class object is created. Structs are best suited 
         * for small data structures that contain primarily data that is not intended to be modified after the struct is created.
        */

        /* 3 pillars of Object Oriented Programming:
         * 
         *  encapsulation - classes can control how much access is given to outside code
         *  inheritance   - 
         *  polymorphism  -
         *  
         */

        //Concepts to show: 
        //nested, virtual\abstract, base\inherited, indexers (generic classes), fields vs properties


        static void Main(string[] args)
        {
        }
    }
}
