using Builder.BuilderOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.DirectorOperation
{
    public class Director 
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }

        }
      

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildMiddleFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.buildPartB();         
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.buildPartB();
            this._builder.buildPartC();
        }

       
    }
}
