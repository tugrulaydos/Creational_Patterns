using Prototype_Pattern.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.SubClassPrototypes
{
    public class Rectangle : Shape
    {
        public int width;
        public int height;

        public Rectangle()
        {

        }

        public Rectangle(Rectangle target) : base(target)
        {
            if (target != null)
            {
                this.width = target.width;
                this.height = target.height;
            }

        }


        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public override bool equals(object object2)
        {
            if (object2.GetType() != typeof(Rectangle) || base.Equals(object2)) return false;

            Rectangle shape2 = (Rectangle)object2;

            return shape2.width == width && shape2.height == height;


        }


    }
}
