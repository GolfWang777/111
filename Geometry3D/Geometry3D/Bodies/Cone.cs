using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry3D
{
    public class Cone : Body
    {
        public double SizeZ { get; }

        public double Radius { get; }

        public Cone(Vector3 position, double sizeZ, double radius) : base(position)
        {
            SizeZ = sizeZ;
            Radius = radius;
        }
		
		public override bool ContainsPoint(Vector3 point) {
			var x_0 = point.X - this.Position.X;
			var y_0 = point.Y - this.Position.Y;
			var z_0 = point.Z - this.Position.Z;
			var r = Math.Sqrt(x_0 * x_0 + y_0 * y_0);
			
			var k = - z_0 / this.Radius;
			
			return k * r + z_0 <= point.Z && this.Position.X - this.Radius <= point.X <= this.Position.X + this.Radius && this.Position.Y - this.Radius <= point.Y <= this.Position.Y + this.Radius;
		}
		
		public override RectangularCuboid GetBoundingBox()
        {
            return new RectangularCuboid(this.Position, this.Radius * 2, this.Radius * 2, this.SizeZ);
        }
    }

}
