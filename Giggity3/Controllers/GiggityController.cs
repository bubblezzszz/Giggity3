using Microsoft.AspNetCore.Mvc;
using GiggityLibrary2;
namespace Giggity3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiggityController : ControllerBase
    {
        private static List<GiggityType> DataList = new();

        public GiggityController()
        {
            if (DataList.Count > 0)
            {
                DataList.Add(new() { Key = 1, Name = "Missionary Giggity", Description = "Normal Boring Shit", IsLegal = true, WitnessesInvolved = 2 });
                DataList.Add(new() { Key = 2, Name = "Cowgirl Giggity", Description = "Slightly Less Normal Boring Shit", IsLegal = true, WitnessesInvolved = 2 });
                DataList.Add(new() { Key = 3, Name = "Reverse Cowgirl Giggity", Description = "Slightly Less boring then not so boring normal shit", IsLegal = true, WitnessesInvolved = 2 });
                DataList.Add(new() { Key = 4, Name = "Doggy Giggity", Description = "The least boring of the normal shit", IsLegal = true, WitnessesInvolved = 2 });
                DataList.Add(new() { Key = 5, Name = "GrassHopper Giggity", Description = "Slightly exciting shit", IsLegal = true, WitnessesInvolved = 3 });
                DataList.Add(new() { Key = 6, Name = "Seal Giggity", Description = "Slightly more exciting then more exciting then normal shit", IsLegal = false, WitnessesInvolved = 3 });
                DataList.Add(new() { Key = 7, Name = "Handstand Giggity", Description = "Where things start to get interesting", IsLegal = false, WitnessesInvolved = 2 });
                DataList.Add(new() { Key = 8, Name = "Yoga Splits Giggity", Description = "Things get very interesting", IsLegal = false, WitnessesInvolved = 2 });
                DataList.Add(new() { Key = 9, Name = "Inverted Splits Giggity", Description = "She may as well be a contortionist", IsLegal = false, WitnessesInvolved = 2 });
            }
        }

        /// <summary>
        /// this is how i get some Giggity
        /// </summary>
        /// <returns></returns>
        /// need post and push
        string giggitygoo = "giggity";
        [HttpGet(Name = "GetSomeGiggity")]
        public GiggityType? GetSomeGiggity(int giggityKey)
        {
            return DataList?.FirstOrDefault(o => o.Key == giggityKey);
        }

        /// <summary>
        /// get a list of giggities
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        [HttpPost(Name = "GetRandomGiggities")]
        public List<GiggityType> GetRandomGiggities(int numberOfGiggities)
        {
            return GiggityRandomizer.GetRandomGiggities(numberOfGiggities);
        }

        /// <summary>
        /// get a list of giggities through push instead of post
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        [HttpPut(Name = "GetSomeMoreThanMoreGiggity")]
        public List<GiggityType> GetSomeMoreThanMoreGiggity(int[] keys)
        {
            return DataList.Where(o => keys.Contains(o.Key)).ToList();
        }

        /// <summary>
        /// Delete a Giggity
        /// </summary>
        /// <param name="key">the key of the giggity2 delete</param>
        [HttpDelete(Name = "DeleteGiggity")]
        public void DeleteGiggity(int key)
        {
            GiggityType? dataItem = DataList.FirstOrDefault(o => o.Key == key);
            if (dataItem != null)
            {
                DataList.Remove(dataItem);
            }
        }
    }
}
