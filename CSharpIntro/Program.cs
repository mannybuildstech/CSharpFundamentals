using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    class Program
    {
        //args array contains command-line arguments excluding executable
        //executable name is included in c++ args
        static int Main(string[] args)
        {
            Console.WriteLine("--  int  --");
            Console.WriteLine("minimum:"+int.MinValue);
            Console.WriteLine("maximum:" + int.MaxValue);
            Console.WriteLine("length:" + sizeof(int));
            Console.WriteLine();

            Console.WriteLine("--  float  --");
            Console.WriteLine("minimum:" + float.MinValue);
            Console.WriteLine("maximum:" + float.MaxValue);
            Console.WriteLine("length:" + sizeof(float));
            Console.WriteLine();

            //Because a string "modification" is actually a new string creation, you must use 
            //caution when you create references to strings. If you create a reference to a string, and then "modify" the original string, 
            //the reference will continue to point to the original object instead of the new object that was created when the string was modified. The following code illustrates this behavior:
            string name = "coder";
            string nameCopy = name;
            
            //this call creates a new string in memory with both strings combined
            // previous value is still in memory until the garbage collector gets rid of it
            name+= " maximus";

            Console.WriteLine("variable nameCopy still holds old value:"+nameCopy); 
            
            //asks console user for character input, preventing program from quitting
            Console.ReadLine();

            /*programs' main function can be void or return an int. It could be read by the caller of the program.
              example: a command-line interface returns error codes that are used to determine the next call in a batch file */
            return 0;
        }

        /* value types are primitive containers:
         * 
         *      Integral - can only express whole numbers
         * 
         *  bool (.net Boolean)    -->  .NET alias is Boolean. 1 byte (only 1/8 bits is needed but processors don't have registers this small?**)
         *  Byte (.net Byte)       --> Alias Byte 1 byte --> unsigned by default
         *  char                   -->  2 bytes, holds unicode characters
         *  short (.net int16)     -->  -- 2 bytes 
         *  int   (.net int32)     -->  -- word in x86 processors**
         *  long  (.net int64)     -->  -- double word in x64 processors**       
         *      
         *  **** Unsigned versions of the above primitives double the range but start from 0 instead of their MinValue
         * 
         *      Floating Types - can express numbers in fractional parts
         * 
         *  float   --> (AKA Single) 32-bit decimal point numbers
         *  double  --> (AKA Double) 64-bit decimal point numbers
         *  decimal --> 12 bytes ** use when very high precision is needed. for ex: financial applications
         *  
         * 
         *  byte
         * */

        /*  user defined types include: 
         *      - enums 
         *      - structs (all numeric value types are structs)
         *      - classes, interfaces (see hierarchy project)
         * 
         */
        
        enum DotNetLanguage
        {
            CSHARP,
            FSHARP,
            CPLUSPLUS,
        }

        /// <summary>
        /// Structs can be used as containers for small amounts of data, they can implement
        /// methods and interfaces but cannot be derived from a class
        /// </summary>
        struct Programmer : LazyHuman
        {
            TimeSpan yearsOfExperience;
            TimeSpan timeSinceGraduation;
            Guid uniqueIdentifier;
            string name;

            bool writeCode(string code)
            {
                Console.WriteLine(name + " wrote the following code:" + Environment.NewLine + "\t");
                return true;
            }

            public TimeSpan sleep()
            {
                return new TimeSpan(12,0,0);
            }
        }

        interface LazyHuman
        {
            TimeSpan sleep();
        }

    }
}
