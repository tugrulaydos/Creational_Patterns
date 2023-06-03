using Prototype_Pattern.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Prototype_Pattern.SubClassPrototypes
{
    public class Circle : Shape
    {
        public int radius;
        public Circle()
        {

        }

        public Circle(Circle target):base(target) 
        {
            if(target != null)
            {
                this.radius= target.radius;
            }

        }

        public override Shape Clone()
        {
            return new Circle(this);
        }

        public override bool equals(object object2)
        {
            if (object2.GetType() != typeof(Circle) || base.Equals(object2)) return false;

            Circle shape2 = (Circle)object2;
            return shape2.radius == radius;
        }       

    }
}
