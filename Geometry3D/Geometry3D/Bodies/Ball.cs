using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry3D
{
    public class Ball : Body
    {
        public double Radius { get; }

        public Ball(Vector3 position, double radius) : base(position)
        {
            Radius = radius;
        }
		
		public override bool ContainsPoint(Vector3 point) {
			var vector = point - Position;
			var length2 = vector.GetLength2();
			return length2 <= ball.Radius * ball.Radius;
		}
		
		public override RectangularCuboid GetBoundingBox()
        {
			var length = this.Radius * 2;
            return new RectangularCuboid(this.Position, length, length, length);
        }
    }

}
