using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Planet : CelestialBody
    {
        private CelestialBody[] _satelliteBodies; //these could be other planets or asteroids (example of polymorphism)

        protected string _planetName = "unknown";

        public CelestialBody[] SatelliteBodies
        {
            get 
            {
                //yoda syntax, supposedly prevents bugs by forcing you to read backwards
                if(null==_satelliteBodies)
                {
                    _satelliteBodies = new CelestialBody[] { }; //its a lonely planet :(
                }
                return _satelliteBodies; 
            }
            set 
            {
                Console.WriteLine("{0} new satellite{1} {2} joined planet {0}'s party!!", value.Length,(value.Length>1)?"'s":"",_planetName);
                _satelliteBodies = value; 
            }
        }

        /// <summary>
        /// constructor can be called using 'base' 
        /// </summary>
        public Planet():base()
        {
            //_masskilograms is protected, meaning Planet can still access it
            Console.WriteLine("Planet with mass=" + _massKilograms + " has been created from the big bang");
        }

        /// <summary>
        /// we override the default behavior, since planets don't emit light (at least I don't think so)
        /// </summary>
        public override bool EmitsLight
        {
            get { return false; }
        }


        public override void TranslateAcrossUniverse()
        {
            
        }
    }
}
