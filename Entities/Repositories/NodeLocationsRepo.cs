using Entities.Abstractions;
using Impact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    class NodeLocationsRepo : INodeLocations<NodeLocations1>
    {
        Game_ImpactContext DB;
        public NodeLocationsRepo()
        {
            DB = new Game_ImpactContext();
        }
        public NodeLocationsRepo(Game_ImpactContext DB)
        {
            this.DB = DB ?? throw new ArgumentNullException(nameof(DB));

        }

        public void CreateNodeLocations(NodeLocations1 NodeLocations)
        {
            throw new NotImplementedException();
        }

        public void DeleteNodeLocations(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NodeLocations1> ReadInNodeLocations()
        {
            throw new NotImplementedException();
        }

        public void UpdateNodeLocations(NodeLocations1 NodeLocations)
        {
            throw new NotImplementedException();
        }
    }
}
