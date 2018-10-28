using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MultiLevelParking
    {

        List<Parking<IAircraft>> parkingStages;

        private const int countPlaces = 16;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<IAircraft>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<IAircraft>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Parking<IAircraft> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}
