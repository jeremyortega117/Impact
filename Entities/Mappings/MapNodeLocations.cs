using Impact.Models;

namespace Entities.Mappings
{
    class MapNodeLocations
    {
        public static NodeLocations1 Map(NodeLocations Orig)
        {
            return new NodeLocations1()
            {
                Id = Orig.Id,
                X = (decimal)Orig.X,
                Y = (decimal)Orig.Y,
                Z = (decimal)Orig.Z,                
            };
        }

        public static NodeLocations Map(NodeLocations1 Orig)
        {
            return new NodeLocations()
            {
                Id = Orig.Id,
                X = Orig.X,
                Y = Orig.Y,
                Z = Orig.Z,
            };
        }
    }
}
