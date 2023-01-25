using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using StringRandomizer;

namespace GiggityLibrary2
{
    public class GiggityRandomizer
    {
        public static List<GiggityType> GetRandomGiggities(int numberOfGiggities)
        {
            // Configuration for vehicle object
            List<GiggityType> returnList = new();
            var randomizer = new Randomizer();
            
            // Properties configuration
            for (int i = 0; i < numberOfGiggities; i++)
            {
                returnList.Add(new() { 
                    Key = i+1, 
                    Name = randomizer.Next(), 
                    Description = randomizer.Next(), 
                    IsLegal = true, 
                    WitnessesInvolved = 2 });
            }

            return returnList;
        }
    }

    
}
