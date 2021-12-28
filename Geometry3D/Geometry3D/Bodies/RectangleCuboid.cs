using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry3D
{
    public class RectangularCuboid : Body
    {
        public double SizeX { get; }
        public double SizeY { get; }
        public double SizeZ { get; }

        public RectangularCuboid(Vector3 position, double sizeX, double sizeY, double sizeZ) : base(position)
        {
            SizeX = sizeX;
            SizeY = sizeY;
            SizeZ = sizeZ;
        }
		
		public bool ContainsPoint(Vector3 point) {
			var minPoint = new Vector3(
				Position.X - cuboid.SizeX / 2,
				Position.Y - cuboid.SizeY / 2,
				Position.Z - cuboid.SizeZ / 2);
			var maxPoint = new Vector3(
				Position.X + cuboid.SizeX / 2,
				Position.Y + cuboid.SizeY / 2,
				Position.Z + cuboid.SizeZ / 2);

			return point >= minPoint && point <= maxPoint;
		}
		
		public override RectangularCuboid GetBoundingBox()
        {
            return this; // Он сам является таковым
        }
    }

}
