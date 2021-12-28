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
			var initialBox = Parts[0].GetBoundingBox();
			
			var Xmin = initialBox.Position.X - initialBox.SizeX / 2;
			var Xmax = initialBox.Position.X + initialBox.SizeX / 2;
			var Ymin = initialBox.Position.Y - initialBox.SizeY / 2;
			var Ymax = initialBox.Position.Y + initialBox.SizeY / 2;
			var Zmin = initialBox.Position.Z - initialBox.SizeZ / 2;
			var Zmax = initialBox.Position.Z + initialBox.SizeZ / 2;
			
			foreach(var body in this.Parts)
			{
				RectangularCuboid box = body.GetBoundingBox();
				var xmin = box.Position.X - box.SizeX / 2;
				var xmax = box.Position.X + box.SizeX / 2;
				var ymin = box.Position.Y - box.SizeY / 2;
				var ymax = box.Position.Y + box.SizeY / 2;
				var zmin = box.Position.Z - box.SizeZ / 2;
				var zmax = box.Position.Z + box.SizeZ / 2;
				
				if(xmin < Xmin) Xmin = xmin;
				if(xmax > Xmax) Xmax = xmax;
				if(ymin < Ymin) Ymin = ymin;
				if(ymax > Ymax) Ymax = ymax;
				if(zmin < Zmin) Zmin = zmin;
				if(zmax > Zmax) Zmax = zmax;
			}
			
            return new RectangularCuboid(new Vector3((Xmax + Xmin) / 2, (Ymax + Ymin) / 2, (Zmax + Zmin) / 2), Xmax - Xmin, Ymax - Ymin, Zmax - Zmin);
        }
    }
}
