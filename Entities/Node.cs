using System;

namespace Entities
{
    public class Node
    {
        public int id { get; set; }
        public Node(int ID)
        {
            this.id = ID;
        }
        public double xVal { get; set; }
        public double yVal { get; set; }
    }
}
