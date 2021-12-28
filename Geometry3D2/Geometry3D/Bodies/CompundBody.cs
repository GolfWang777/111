using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry3D
{
    public class CompoundBody : Body
    {
        public IReadOnlyList<Body> Parts { get; }

        public CompoundBody(IReadOnlyList<Body> parts) : base(parts[0].Position)
        {
            Parts = parts;
        }
		
		public override bool ContainsPoint(Vector3 point) {
			return this.Parts.Any(body => body.ContainsPoint(point));
		}
		
		public override RectangularCuboid GetBoundingBox()
        {
			var sizeX = 0.0;
			var sizeY = 0.0;
			var sizeZ = 0.0;
            return new RectangularCuboid(boxPosition, sizeX, sizeY, sizeZ);
        }
    }
}
