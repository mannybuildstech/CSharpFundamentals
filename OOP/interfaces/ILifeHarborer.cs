using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.interfaces
{
    /*
    An interface contains definitions for a group of related functionalities that a class or a struct can implement.
    By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is 
    important in C# because the language doesn't support multiple inheritance of classes. 
    In addition, you must use an interface if you want to simulate inheritance for structs, because they can't actually inherit from another struct or class.
    */
    public interface ILifeHarborer
    {
        /// <summary>
        /// life harborer must provide some kind of 
        /// nutrition for species to survive
        /// </summary>
        void nutritionOpportunities();

        /// <summary>
        /// what is the current dominant species ?
        /// </summary>
        void dominantSpecies();

        /// <summary>
        /// overtime, the environment shapes
        ///  & changes species
        /// </summary>
        void evolveSpecies();

        /// <summary>
        /// is there microscopic life here?
        /// </summary>
        /// <returns></returns>
        bool microscopicLife();

        /// <summary>
        /// is there complex life?
        /// </summary>
        /// <returns></returns>
        bool macroscopicLife();
    }
}
