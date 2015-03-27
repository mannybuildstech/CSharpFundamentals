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
         *  encapsulation - classes can control how much access is given to outsiders
         *  inheritance   - classes can be derived from others inheriting their components
         *  polymorphism  - classes can take multiple forms, using inheritance & interfaces
         *  
         */

        //Concepts to show: 
        //indexers (generic classes), 

        public class Shape
        {
            // A few example members 
            public int X { get; private set; }
            public int Y { get; private set; }
            public int Height { get; set; }
            public int Width { get; set; }

            // Virtual method 
            public virtual void Draw()
            {
                Console.WriteLine("Performing base class drawing tasks");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                // Code to draw a circle...
                Console.WriteLine("Drawing a circle");
                base.Draw();
            }
        }
        class Rectangle : Shape
        {
            public override void Draw()
            {
                // Code to draw a rectangle...
                Console.WriteLine("Drawing a rectangle");
                base.Draw();
            }
        }
        class Triangle : Shape
        {
            public override void Draw()
            {
                // Code to draw a triangle...
                Console.WriteLine("Drawing a triangle");
                base.Draw();
            }
        }

        static void Main(string[] args)
        {
            // Polymorphism at work #1: a Rectangle, Triangle and Circle 
            // can all be used whereever a Shape is expected. No cast is 
            // required because an implicit conversion exists from a derived  
            // class to its base class.
            System.Collections.Generic.List<Shape> shapes = new System.Collections.Generic.List<Shape>();
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());

            // Polymorphism at work #2: the virtual method Draw is 
            // invoked on each of the derived classes, not the base class. 
            foreach (Shape s in shapes)
            {
                s.Draw();
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
