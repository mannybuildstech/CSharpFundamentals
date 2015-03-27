using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOP.interfaces;

namespace OOP
{
    public class EarthLikePlanet: Planet,ILifeHarborer
    {
        public EarthLikePlanet(string name):base()
        {
            base._planetName = name;
        }

        public override void TranslateAcrossUniverse()
        {
            base.TranslateAcrossUniverse();

            Console.WriteLine("This planet, in particular; traverses around the start sol-345");
        }

        #region ILifeHarborer

        public void nutritionOpportunities()
        {
            Console.WriteLine("Swarms of fish fill the oceans");
            Console.WriteLine("Swarms of birds cover the skies.");
            Console.WriteLine("oh and some green stuff too..");
        }

        public void dominantSpecies()
        {
            Console.WriteLine("Humanz mens r dee dominent speecieees at the moment");
        }

        public void evolveSpecies()
        {
            Console.WriteLine("Over the millenia, species have gone from single celled to thinking survival machines...");
            throw new NotImplementedException();
        }

        public bool microscopicLife()
        {
            Console.WriteLine("Unseen to the eye, there is a Universe of tiny microorganisms");
            return true;
        }

        public bool macroscopicLife()
        {
            Console.WriteLine("There are hominids here");
            Console.WriteLine("There are canines here");
            Console.WriteLine("There are felines here");
            return true;
        }

        #endregion
    }
}
