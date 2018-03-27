using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMania
{
    static class LaneCreator
    {

        public static List<Lane> createLanes(float posX)
        {
            List<Lane> returningLanes = new List<Lane>();

            for (int i = 0; i < Settings.keyAmount; i++)
            {
                returningLanes.Add(new Lane()
                {
                    width = Helper.laneWidthCalculator(),
                    key = Settings.keyGroups[Settings.keyAmount.ToString()+"K"][i],
                    posX = posX + Helper.laneWidthCalculator() * i,
                    receptor = ReceptorCreator.createReceptor(i, posX + Helper.laneWidthCalculator() * i)
                });
            }

            return returningLanes;
        }
    }
}
