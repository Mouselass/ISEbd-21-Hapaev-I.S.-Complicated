using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seaplane
{
    class AerodromeCollection
    {
        readonly Dictionary<string, Aerodrome<Vehicle, CircleForm>> aerodromeStages;

        public List<string> Keys => aerodromeStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public AerodromeCollection(int pictureWidth, int pictureHeight)
        {
            aerodromeStages = new Dictionary<string, Aerodrome<Vehicle, CircleForm>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                return;
            }

            aerodromeStages.Add(name, new Aerodrome<Vehicle, CircleForm>(pictureWidth, pictureHeight));
        }

        public void DelAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                aerodromeStages.Remove(name);
            }
        }

        public Aerodrome<Vehicle, CircleForm> this[string ind]
        {
            get
            {
                if (aerodromeStages.ContainsKey(ind))
                {
                    return aerodromeStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public Vehicle this[string key, int ind]
        {
            get
            {
                if (aerodromeStages.ContainsKey(key) && ind >= 0)
                {
                    return aerodromeStages[key]._places[ind];
                }
                return null;
            }
        }
    }
}