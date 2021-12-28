using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry3D
{
    public abstract class Body
    {
        public Vector3 Position { get; }

        protected Body(Vector3 position)
        {
            Position = position;
        }

        public bool ContainsPoint(Vector3 point);
        {
            throw new NotImplementedException("Unknown body!");
        }

        public RectangularCuboid GetBoundingBox()
        {
            throw new NotImplementedException("Unknown body!");
        }
    }

}
