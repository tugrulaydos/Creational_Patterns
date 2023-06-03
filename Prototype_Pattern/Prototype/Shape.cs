using Prototype_Pattern.SubClassPrototypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype_Pattern.Prototype
{
    public abstract class Shape
    {
        public int x;
        public int y;

        public string color;

        public Shape()
        {

        }

        public Shape(Shape target)
        {
            if (target != null)
            {
                this.x = target.x;
                this.y=target.y;
                this.color = target.color;
            }

        }

        public abstract Shape Clone();

        public virtual bool equals(Object object2)
        {
            if(object2.GetType() != typeof(Shape))
            {
                return false;
            }
            Shape shape2 = (Shape)object2;

            return shape2.x == x && shape2.y == y && shape2.color == color;

        }


       

        


        
    }
}
